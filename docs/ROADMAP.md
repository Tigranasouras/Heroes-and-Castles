# 🗺️ Heroes & Castles — Development Roadmap

[← Home](../README.md) · [Current exercise](EXERCISES.md) · [Reading guide](READING.md) · [Architecture](ARCHITECTURE.md)

Build the game **in C# first, in Unity later**. Progress is based on working, testable systems rather than calendar deadlines.

| Phase | Game feature | Professional C# skills | Relevant reading | Progress |
|---|---|---|---|---|
| **01. Combat foundation** | Monster, Brute, Archer, reusable health and attack | OOP, constructors, interfaces, composition, nullability | [Component](https://gameprogrammingpatterns.com/component.html), [Type Object](https://gameprogrammingpatterns.com/type-object.html) | 🟡 In progress |
| **02. Events** | Damage, death, logging, presentation notifications | Delegates, Action, events, subscriptions | [Observer](https://gameprogrammingpatterns.com/observer.html), [Event Queue](https://gameprogrammingpatterns.com/event-queue.html) | ⬜ Planned |
| **03. Enemy AI** | Idle, chase, attack, retreat, die | State machines, enums, switch, polymorphism | [State](https://gameprogrammingpatterns.com/state.html) | ⬜ Planned |
| **04. Simulation loop** | Multiple monsters progressing per tick | Collections, time steps, deterministic tests | [Game Loop](https://gameprogrammingpatterns.com/game-loop.html), [Update Method](https://gameprogrammingpatterns.com/update-method.html) | ⬜ Planned |
| **05. Castles and waves** | Castle health, spawning, victory and defeat | Generics, dictionaries, LINQ, design boundaries | [Command](https://gameprogrammingpatterns.com/command.html), [Prototype](https://gameprogrammingpatterns.com/prototype.html) | ⬜ Planned |
| **06. Quality engineering** | Test suite, CI, logging, review practices | Testing, debugging, exceptions, Git | [Contribution workflow](../CONTRIBUTING.md) | ⬜ Ongoing |
| **07. Unity integration** | Characters, scenes, animation, UI | Unity APIs, serialization, prefabs, engine lifecycle | [Unity Manual](https://docs.unity3d.com/Manual/) | ⬜ Planned |
| **08. Performance** | Large waves, projectile reuse, efficient targeting | Profiling, allocation, data structures | [Object Pool](https://gameprogrammingpatterns.com/object-pool.html), [Spatial Partition](https://gameprogrammingpatterns.com/spatial-partition.html) | ⬜ Planned |

## Definition of done
- [ ] The gameplay behavior has clear requirements.
- [ ] The logic runs without Unity where practical.
- [ ] Normal, failure, and edge cases have tests.
- [ ] Components avoid duplicated authoritative state.
- [ ] Code passes review and is committed with a descriptive message.

## Breadth curriculum

We'll work in C# language features beyond game patterns: value vs reference types, structs, records, generics, collections, nullability, exceptions, LINQ, complexity, async/await where useful, memory management, profiling, and automated tests.
