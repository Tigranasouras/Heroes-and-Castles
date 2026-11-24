# Steam and multiplayer readiness

Steam is the intended distribution platform, not a dependency of the game rules. Offline development and single-player must work without Steam.

## Early technical spike
- [ ] Select supported Unity version and verify C#/.NET compatibility with Game.Core (currently net10.0).
- [ ] Build a minimal Windows executable with placeholder scene.
- [ ] Evaluate Steamworks.NET and Facepunch.Steamworks against engine/build targets; record decision.
- [ ] Initialize Steam, process callbacks and shut down cleanly; test unavailable client and offline fallback.
- [ ] Verify overlay in a packaged build using an authorized test App ID; do not ship a sample App ID.
- [ ] Test two separate accounts/clients joining and leaving a lobby, reconnecting and exchanging a minimal command.
- [ ] Compare networking frameworks and Steam transport compatibility before selection.

## Design constraints
Use stable game entity IDs separate from platform account IDs; version save and network formats; keep authoritative simulation separate from visual state. Route player and AI intentions through shared commands. Validate sender identity, ownership, legality and rate limits on the authoritative host/server. Steam lobbies and relays do not implement gameplay replication or authority. Do not promise deterministic lockstep across Unity physics or platforms.

Keep platform adapters outside Game.Core; introduce narrow interfaces when real use cases emerge. Test local and Steam implementations. Local saves must work before cloud synchronization. Plan conflict handling, achievements, input, private builds and release testing. Never commit credentials or partner secrets.

## References
- [Steamworks SDK](https://partner.steamgames.com/doc/sdk)
- [Steam networking](https://partner.steamgames.com/doc/features/multiplayer/networking)
- [Steam Direct](https://partner.steamgames.com/steamdirect)
- [Steamworks.NET](https://steamworks.github.io/)
- [Facepunch.Steamworks](https://github.com/Facepunch/Facepunch.Steamworks)
- [Unity multiplayer](https://docs-multiplayer.unity3d.com/)
- [Mirror](https://mirror-networking.gitbook.io/docs/)

No SDK, transport, hosting model or release date has been selected. Validate licensing, fees and distribution requirements before commercial onboarding.
