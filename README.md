# SunFixer
As a fix for poor shadow behavior, KSP 1.3 rounded the sun's angle/position
to very low precision as a workaround for a bug in Unity's directional
light. This resulted in shadows jerking across the ground as time passes.
Thankfully, the rounding is controllable, so this mod sets the rounding to
be fairly high precision, bringing back smooth motion to the shadows.
