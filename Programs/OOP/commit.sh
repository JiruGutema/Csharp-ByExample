#!/usr/bin/env bash
# Run from repo root. Commits each top-level folder with changes as a separate feat commit.
set -euo pipefail

git_root=$(git rev-parse --show-toplevel)
cd "$git_root"

for d in */; do
  [ -d "$d" ] || continue
  dir=${d%/}
  # skip .git if somehow present
  [ "$dir" = ".git" ] && continue

  status=$(git status --porcelain -- "$dir")
  if [ -n "$status" ]; then
    echo "Staging and committing: $dir"
    # choose message based on whether there are untracked files
    if echo "$status" | grep -q '^??'; then
      msg="feat($dir): add files for $dir"
    else
      msg="feat($dir): update for $dir"
    fi

    git add -- "$dir"
    if git commit -m "$msg"; then
      echo "Committed: $msg"
    else
      echo "Nothing to commit for: $dir"
      git reset --quiet
    fi
  else
    echo "No changes in: $dir"
  fi
done