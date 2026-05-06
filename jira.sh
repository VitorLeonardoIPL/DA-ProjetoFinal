#!/bin/bash
# Quick access to Jira scripts from project root

if [ "$1" == "task" ]; then
    python jira/scripts/create-task.py
elif [ "$1" == "list" ]; then
    python jira/scripts/jira-cli.py list "$@"
elif [ "$1" == "create" ]; then
    python jira/scripts/jira-cli.py create "$@"
elif [ "$1" == "sprints" ]; then
    python jira/scripts/jira-cli.py sprints "$@"
else
    echo "Usage: ./jira.sh [task|list|create|sprints]"
    echo ""
    echo "Examples:"
    echo "  ./jira.sh task                                  # Create task interactively"
    echo "  ./jira.sh list --max 5                          # List recent tasks"
    echo "  ./jira.sh create --summary 'New feature'        # Create via CLI"
    echo "  ./jira.sh sprints                               # List sprints"
fi
