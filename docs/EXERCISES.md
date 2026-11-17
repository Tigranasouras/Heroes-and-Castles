# 🧪 Hands-on Exercises

[← Home](../README.md) · [Roadmap](ROADMAP.md) · [Reading guide](READING.md)

## Current: Exercise 9 — Reusable combat components

**Goal:** Remove duplicate `Attacking()` logic from `Brute` and `Archer` while keeping different enemy configurations.

- [ ] Give `Attack` a constructor that accepts a damage amount.
- [ ] Let `Attack` own its damage value.
- [ ] Give `Monster` an attack component.
- [ ] Move shared `Attacking(Monster target)` into `Monster`.
- [ ] Initialize required components through constructors.
- [ ] Prevent dead attackers or targets from participating in an attack.
- [ ] Add a health-change event with appropriate subscription handling.
- [ ] Simulate combat through death, without negative health.

### Acceptance tests
- [ ] Brute and Archer can use the same inherited attack entry point.
- [ ] Target health decreases by exactly the configured damage, to a minimum of zero.
- [ ] Dead attackers cannot deal damage.
- [ ] Dead targets cannot be attacked through the attack API.
- [ ] A successful health reduction notifies listeners exactly once.
- [ ] No separate authoritative health values exist in subclasses.

### Design question

Should `Attack` hold a reference to the owner, or receive the target as a method argument? Compare coupling and unit-test simplicity.

**Read:** [Component](https://gameprogrammingpatterns.com/component.html) · [Observer](https://gameprogrammingpatterns.com/observer.html)

## Upcoming: Exercise 10 — Event observers

- [ ] Subscribe a combat log listener to damage and death events.
- [ ] Unsubscribe when the listener is no longer needed.
- [ ] Confirm one event does not accidentally produce duplicate callbacks.

## Upcoming: Exercise 11 — Enemy states

- [ ] Define Idle, Chase, Attack, and Dead.
- [ ] Make transitions explicit and validate them.
- [ ] Test that dead enemies cannot resume movement or attacks.

**Read:** [State](https://gameprogrammingpatterns.com/state.html)
