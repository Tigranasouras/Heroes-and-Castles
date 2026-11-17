# 🏰 Heroes & Castles

**A C#-first, Unity-ready fantasy castle-defense game and professional game-development learning project.**

> **Current phase:** Combat foundations · **Workflow:** Build and test the core gameplay on the laptop, integrate visuals in Unity later.

[![Roadmap](https://img.shields.io/badge/Roadmap-Explore-blue)](docs/ROADMAP.md) [![Architecture](https://img.shields.io/badge/Architecture-View-purple)](docs/ARCHITECTURE.md) [![Current Exercise](https://img.shields.io/badge/Next-Exercise%2009-orange)](docs/EXERCISES.md) [![Patterns](https://img.shields.io/badge/Reading-Game%20Programming%20Patterns-green)](https://gameprogrammingpatterns.com/contents.html)

## 🎯 Project vision

Create a fantasy castle-defense game with heroes, Brutes, Archers, autonomous enemy AI, reusable combat components, wave spawning, and a defendable castle. Learn professional C# and software engineering principles as each feature becomes necessary.

## 🧭 Explore the project

| Resource | Purpose |
|---|---|
| [🗺️ Development roadmap](docs/ROADMAP.md) | Eight stages from combat through Unity optimization |
| [🧪 Next coding challenge](docs/EXERCISES.md) | Exercise 9 with acceptance criteria |
| [🧱 Architecture](docs/ARCHITECTURE.md) | Independent simulation core and future Unity integration |
| [📚 Interactive reading guide](docs/READING.md) | Clickable chapters of *Game Programming Patterns* |
| [🤝 Contribution workflow](CONTRIBUTING.md) | Git branches, review, and test checklist |
| [🎯 Exercise 9 — Current task](../../issues/1) | Live checkbox tracker for component refactoring |
| [🛠️ Engineering setup](../../issues/2) | Create class library, console runner, and tests |
| [🤖 Enemy AI states](../../issues/3) | Upcoming AI exercise |
| [🐛 All issues and tasks](../../issues) | Track exercises and bugs using GitHub checkboxes |

## 📈 Learning and implementation progress

- [x] Explore classes, constructors, inheritance, and polymorphism
- [x] Introduce a reusable `HealthComponent`
- [ ] **[Exercise 9](../../issues/1):** Refactor shared attack logic into a component
- [ ] Publish damage/death events and manage subscriptions
- [ ] **[AI states](../../issues/3):** Implement Idle, Chase, Attack, and Dead enemy states
- [ ] Create a deterministic multi-enemy simulation loop
- [ ] Implement castle health, enemy waves, and victory conditions
- [ ] **[Engineering setup](../../issues/2):** Add automated tests and continuous integration
- [ ] Integrate with Unity prefabs, animation, physics, and UI
- [ ] Profile larger battles and optimize carefully

## 🏗️ Planned code organization

```text
src/
  Game.Core/          # Pure C# game logic
  Game.Console/       # Console testbed for headless gameplay
tests/
  Game.Tests/         # Automated tests
docs/                 # Roadmap, architecture, exercises, reading
.github/
  ISSUE_TEMPLATE/     # Reusable GitHub task templates
```

**Repository status:** Documentation and planning scaffold. The C# code from local `_04_Component` exercises has not yet been migrated. We will introduce buildable projects and tests as the next development steps.

## 💻 Development philosophy

**Build logic first, visuals later.** Health, damage, AI, target selection, and win conditions should run in a C# simulation without `UnityEngine`. Unity will eventually adapt these systems to the visual game. Physics, rendering, animation, and Unity-specific lifecycle behavior must still be tested in Unity.

Learn each concept through implementation, deliberate testing, and code review. Prefer readable code and justified composition over unnecessary abstraction.

## 🔗 References

- [Game Programming Patterns — full contents](https://gameprogrammingpatterns.com/contents.html)
- [Microsoft C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Unity Manual](https://docs.unity3d.com/Manual/)
- [GitHub documentation](https://docs.github.com/)

---

*This repository is our working learning project. Progress checkboxes in Markdown are updated by commits; GitHub Issues provide separately interactive task checklists.*
