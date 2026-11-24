# Development Workflow

[← Home](README.md) · [Exercise board](docs/EXERCISES.md)

Work in small features. Branch names such as `feature/combat-components` make the Git history readable.

1. Select one exercise or issue.
2. Write expected behavior and edge cases.
3. Implement the smallest correct change.
4. Run console checks and automated tests (once projects are configured).
5. Commit descriptive changes; e.g. `feat(combat): centralize attack damage`.
6. Request code review and update the roadmap.

## Review checklist
- [ ] No duplicated authoritative state
- [ ] Consistent C# naming (`PascalCase` for public members)
- [ ] Proper null and invalid argument handling
- [ ] Clear component ownership
- [ ] Event listeners unsubscribe when appropriate
- [ ] Tests check unhappy paths as well as success
- [ ] No unnecessary Unity coupling in `Game.Core`

## Mentored engineering sessions
Start with the current issue, branch and latest commit. Mentor explains theory and assigns reading, then provides requirements and hints; learner attempts implementation before requesting a complete solution. Review correctness, readability, dependency direction, edge cases and tests. Run dotnet build and dotnet test against the solution once verified locally. Open a PR with evidence, update issue checkboxes only when verified, and record significant decisions in docs/DECISIONS.md. Never commit credentials. Use small branches and meaningful commits; do not claim tests passed without running them.
