# Architecture decision records

Status: accepted design direction, implementation pending unless verified. Revisit when evidence changes.

| ID | Decision | Rationale / trade-off |
|---|---|---|
| ADR-001 | Pure C# core independent of Unity where practical | Testability; engine physics and presentation remain engine-specific |
| ADR-002 | Isolate Steam adapters | Offline testing; extra integration boundary |
| ADR-003 | Shared commands across player perspectives and AI | Consistent rules; avoid premature command framework |
| ADR-004 | Separate authoritative simulation and presentation | Supports replication; requires explicit state ownership |
| ADR-005 | Stable IDs and versioned persistence | Supports migration and networking; schema maintenance |
| ADR-006 | Early Unity/Steam compatibility spike | Reduces late refactors; time spent on technical prototype |
| ADR-007 | Manual constructor injection before DI container | Learn dependencies; revisit when wiring becomes complex |

For new decisions record context, alternatives, choice, consequences, validation and status. No framework or target framework migration is approved by this document.
