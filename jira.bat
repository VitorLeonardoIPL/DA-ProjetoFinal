@echo off
REM Quick access to Jira scripts from project root

if "%1"=="task" (
    python jira\scripts\create-task.py
) else if "%1"=="list" (
    python jira\scripts\jira-cli.py list %*
) else if "%1"=="create" (
    python jira\scripts\jira-cli.py create %*
) else if "%1"=="sprints" (
    python jira\scripts\jira-cli.py sprints %*
) else (
    echo Usage: jira.bat [task^|list^|create^|sprints]
    echo.
    echo Examples:
    echo   jira.bat task                              - Create task interactively
    echo   jira.bat list --max 5                      - List recent tasks
    echo   jira.bat create --summary "New feature"    - Create via CLI
    echo   jira.bat sprints                           - List sprints
)
