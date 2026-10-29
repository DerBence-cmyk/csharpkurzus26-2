using System;
using System.Collections.Generic;
using System.Text;

using GPMIDIConvert.Core.Domain.Storage;

namespace GPMIDIConvert.Core.Domain.MIDI_Conversion.Templates;

public abstract class InstrumentProfile
{
    public abstract string LibraryName { get; }

    public MIDIScore TranslateScore(GuitarProScore score, int ticksPerQuarterNote)
    {
        var midiTracks = new List<MIDITrack>(score.Tracks.Count);

        foreach (var gpTrack in score.Tracks)
        {
            midiTracks.Add(CreateTracks(gpTrack));
        }

        return new MIDIScore(ticksPerQuarterNote, midiTracks);
    }

    public MIDITrack CreateTracks(GuitarProTrack track)
    {
        var newEventList = new List<MIDIEvent>();

        newEventList.Add(new TrackNameMetaEvent(0, track.Name));

        foreach (var note in track.Notes)
        {
            ProcessNoteArticulation(note, newEventList);
        }

        var sorted = newEventList
            .OrderBy(e => e.absoluteTick)
            .ToList();

        return new MIDITrack(track.TrackID, track.Name, sorted);
    }

    public static void AddNote(List<MIDIEvent> eventList, GuitarProNote note)
    {
        int channel = note.StringNumber;

        eventList.Add(new NoteOnMIDIEvent(
            AbsoluteTick: note.StartTick,
            Channel: channel,
            Pitch: note.MidiPitch,
            Velocity: note.Velocity
        ));

        eventList.Add(new NoteOffMIDIEvent(
            AbsoluteTick: note.StartTick + note.DurationTicks,
            Channel: channel,
            Pitch: note.MidiPitch,
            Velocity: 0
        ));
    }

    public virtual void ProcessNoteArticulation(GuitarProNote note, List<MIDIEvent> eventList)
    {
        if (note.Articulations is null || note.Articulations.Count == 0)
        {
            AddNote(eventList, note);
            return;
        }

        foreach (var articulation in note.Articulations)
        {
            switch (articulation)
            {
                default:
                    break;
            }
        }

        AddNote(eventList, note);

    }
}
