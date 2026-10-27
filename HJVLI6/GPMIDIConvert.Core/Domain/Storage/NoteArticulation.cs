using System;
using System.Collections.Generic;
using System.Text;

namespace GPMIDIConvert.Core.Domain.Storage;

public abstract record NoteArticulation;


public sealed record PalmMuteArticulation : NoteArticulation;
public sealed record DeadNoteArticulation : NoteArticulation;
public sealed record DeadSlapArticulation : NoteArticulation;
public sealed record LetRingArticulation : NoteArticulation;
public sealed record TapArticulation : NoteArticulation;
public sealed record SlapArticulation : NoteArticulation;
public sealed record PopArticulation : NoteArticulation;
public sealed record GhostNoteArticulation : NoteArticulation;


public sealed record PickStrokeArticulation(string direction) : NoteArticulation;
public sealed record BrushArticulation(string direction, int durationTicks) : NoteArticulation;
public sealed record ArpeggioArticulation(string direction, int durationTicks) : NoteArticulation;


public sealed record GolpeArticulation(string type) : NoteArticulation;
public sealed record OrnamentArticulation(string type) : NoteArticulation;


public sealed record GraceNoteArticulation(string placement) : NoteArticulation;

public sealed record TremoloPickingArticulation(string fraction) : NoteArticulation;
public sealed record TrillArticulation(int targetPitch, int speedTicks) : NoteArticulation;


public sealed record AccentArticulation(int accentFlags) : NoteArticulation;
public sealed record SlideArticulation(int slideFlags) : NoteArticulation;


public sealed record VibratoArticulation(string strength, bool isTremolo) : NoteArticulation;

public sealed record TieArticulation(bool isOrigin, bool isDestination) : NoteArticulation;
public sealed record LegatoArticulation(bool isOrigin, bool isDestination) : NoteArticulation;
public sealed record HopoArticulation(bool isOrigin, bool isDestination) : NoteArticulation;


public sealed record HarmonicArticulation(
    string Type,
    decimal Fret
) : NoteArticulation;

public sealed record WhammyArticulation(
    decimal OriginValue,
    decimal OriginOffset,
    decimal MiddleValue,
    decimal MiddleOffset1,
    decimal MiddleOffset2,
    decimal DestinationValue,
    decimal DestinationOffset
) : NoteArticulation;

public sealed record BendArticulation(
    decimal OriginValue,
    decimal OriginOffset,
    decimal MiddleValue,
    decimal MiddleOffset1,
    decimal MiddleOffset2,
    decimal DestinationValue,
    decimal DestinationOffset
) : NoteArticulation;