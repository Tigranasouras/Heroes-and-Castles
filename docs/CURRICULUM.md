# Professional engineering curriculum

[Home](../README.md) · [Roadmap](ROADMAP.md) · [Exercises](EXERCISES.md) · [Workflow](../CONTRIBUTING.md)

Mastery-based, not calendar-based. Each module requires explanation, independent implementation, tests, review and a commit. Existing Exercise 9 is our starting point (HAC-001); do not restart from scratch.

| Module | Topics | Practical outcome |
|---|---|---|
| I.1 | OOP, encapsulation, polymorphism | Review existing Monster/Brute/Archer |
| I.2 | Interfaces, composition, constructor injection | HAC-001 reusable combat |
| I.3 | Generics, collections, LINQ, value/reference types, nullability | Entity registry |
| I.4 | Delegates, events, observer | Combat notifications |
| I.5 | SOLID, coupling, cohesion, composition roots | Explicit service wiring |
| I.6 | Exceptions, debugging, xUnit, Git, CI | Reliable test suite |
| I.7 | Complexity, queues, dictionaries, graphs | Explain data structure choices |
| II.1 | Game loops, ticks, seeded randomness | Headless simulation |
| II.2 | Identity, components, factories | Configurable units |
| II.3 | Damage, armor, cooldowns, targeting | Combat scenarios |
| II.4 | State machines, behavior trees, utility AI | Enemy behavior |
| II.5 | Vectors, A*, spatial partitioning | Movement prototype |
| II.6 | Commands, ownership, formations | Army orders |
| II.7 | Economy, construction, versioned persistence | Castle management |
| III.1 | Unity lifecycle, scenes, physics | Minimal executable and Steam spike |
| III.2 | Prefabs, ScriptableObjects, assemblies | Data-driven units |
| III.3 | Cameras, animation, input | First/third-person and strategy controls |
| III.4 | Core integration and engine tests | Playable prototype |
| III.5 | DI scopes, additive scenes, async loading | Scoped services where justified |
| III.6 | Editor tooling, inspectors | Content authoring |
| IV.1 | Profiling, allocations, benchmarks | Measured battle performance |
| IV.2 | ECS/DOTS, Jobs, Burst | Evaluate against baseline; optional adoption |
| IV.3 | Concurrency, tasks, thread safety | Safe background work |
| IV.4 | Authority, replication, transport, Steam lobbies | Two-player prototype |
| IV.5 | CI/CD, logs, builds, regression tests | Repeatable releases |
| IV.6 | Steam packaging, private tests, maintenance | Release candidate |

## Gates
- I: Tested console combat; early Unity compatibility experiment before expanding core.
- II: Castle-defense simulation with army commands and versioned saves.
- III: Playable 3D vertical slice; Steam initialization/overlay and two-player connectivity tested early, not deferred to release.
- IV: Profiled vertical slice, authoritative multiplayer prototype, release checklist. Commercial release remains contingent on scope and quality.

## Reading
- [Microsoft C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Game Programming Patterns](https://gameprogrammingpatterns.com/)
- [Microsoft DI guidelines](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-guidelines)
- [Unit testing best practices](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
- [Unity Learn](https://learn.unity.com/pathway/junior-programmer)
- [Unity assembly definitions](https://docs.unity3d.com/Manual/assembly-definitions.html)
- [GitHub Actions](https://docs.github.com/en/actions)
- [Gaffer on Games](https://gafferongames.com/)
- [Steamworks documentation](https://partner.steamgames.com/doc/home)

Read relevant sections before each ticket, not every resource upfront. Explain trade-offs and complete occasional independent transfer exercises. 
