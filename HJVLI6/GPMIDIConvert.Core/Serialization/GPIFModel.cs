using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GPMIDIConvert.Core.Serialization;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class GPIF
{

    private string gPVersionField;

    private GPIFGPRevision gPRevisionField;

    private GPIFEncoding encodingField;

    private GPIFScore scoreField;

    private GPIFMasterTrack masterTrackField;

    private GPIFTracks tracksField;

    private GPIFMasterBar[] masterBarsField;

    private GPIFBar[] barsField;

    private GPIFVoice[] voicesField;

    private GPIFBeat[] beatsField;

    private GPIFNote[] notesField;

    private GPIFRhythm[] rhythmsField;

    private GPIFScoreView[] scoreViewsField;

    /// <remarks/>
    public string GPVersion
    {
        get
        {
            return this.gPVersionField;
        }
        set
        {
            this.gPVersionField = value;
        }
    }

    /// <remarks/>
    public GPIFGPRevision GPRevision
    {
        get
        {
            return this.gPRevisionField;
        }
        set
        {
            this.gPRevisionField = value;
        }
    }

    /// <remarks/>
    public GPIFEncoding Encoding
    {
        get
        {
            return this.encodingField;
        }
        set
        {
            this.encodingField = value;
        }
    }

    /// <remarks/>
    public GPIFScore Score
    {
        get
        {
            return this.scoreField;
        }
        set
        {
            this.scoreField = value;
        }
    }

    /// <remarks/>
    public GPIFMasterTrack MasterTrack
    {
        get
        {
            return this.masterTrackField;
        }
        set
        {
            this.masterTrackField = value;
        }
    }

    /// <remarks/>
    public GPIFTracks Tracks
    {
        get
        {
            return this.tracksField;
        }
        set
        {
            this.tracksField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("MasterBar", IsNullable = false)]
    public GPIFMasterBar[] MasterBars
    {
        get
        {
            return this.masterBarsField;
        }
        set
        {
            this.masterBarsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Bar", IsNullable = false)]
    public GPIFBar[] Bars
    {
        get
        {
            return this.barsField;
        }
        set
        {
            this.barsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Voice", IsNullable = false)]
    public GPIFVoice[] Voices
    {
        get
        {
            return this.voicesField;
        }
        set
        {
            this.voicesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Beat", IsNullable = false)]
    public GPIFBeat[] Beats
    {
        get
        {
            return this.beatsField;
        }
        set
        {
            this.beatsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Note", IsNullable = false)]
    public GPIFNote[] Notes
    {
        get
        {
            return this.notesField;
        }
        set
        {
            this.notesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Rhythm", IsNullable = false)]
    public GPIFRhythm[] Rhythms
    {
        get
        {
            return this.rhythmsField;
        }
        set
        {
            this.rhythmsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ScoreView", IsNullable = false)]
    public GPIFScoreView[] ScoreViews
    {
        get
        {
            return this.scoreViewsField;
        }
        set
        {
            this.scoreViewsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFGPRevision
{

    private int requiredField;

    private int recommendedField;

    private int valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int required
    {
        get
        {
            return this.requiredField;
        }
        set
        {
            this.requiredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int recommended
    {
        get
        {
            return this.recommendedField;
        }
        set
        {
            this.recommendedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public int Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFEncoding
{

    private string encodingDescriptionField;

    /// <remarks/>
    public string EncodingDescription
    {
        get
        {
            return this.encodingDescriptionField;
        }
        set
        {
            this.encodingDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFScore
{

    private string titleField;

    private string subTitleField;

    private string artistField;

    private string albumField;

    private string wordsField;

    private string musicField;

    private string wordsAndMusicField;

    private string copyrightField;

    private string tabberField;

    private string instructionsField;

    private string noticesField;

    private string firstPageHeaderField;

    private string firstPageFooterField;

    private string pageHeaderField;

    private string pageFooterField;

    private int scoreSystemsDefaultLayoutField;

    private object scoreSystemsLayoutField;

    private string scoreZoomPolicyField;

    private int scoreZoomField;

    private int multiVoiceField;

    /// <remarks/>
    public string Title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    /// <remarks/>
    public string SubTitle
    {
        get
        {
            return this.subTitleField;
        }
        set
        {
            this.subTitleField = value;
        }
    }

    /// <remarks/>
    public string Artist
    {
        get
        {
            return this.artistField;
        }
        set
        {
            this.artistField = value;
        }
    }

    /// <remarks/>
    public string Album
    {
        get
        {
            return this.albumField;
        }
        set
        {
            this.albumField = value;
        }
    }

    /// <remarks/>
    public string Words
    {
        get
        {
            return this.wordsField;
        }
        set
        {
            this.wordsField = value;
        }
    }

    /// <remarks/>
    public string Music
    {
        get
        {
            return this.musicField;
        }
        set
        {
            this.musicField = value;
        }
    }

    /// <remarks/>
    public string WordsAndMusic
    {
        get
        {
            return this.wordsAndMusicField;
        }
        set
        {
            this.wordsAndMusicField = value;
        }
    }

    /// <remarks/>
    public string Copyright
    {
        get
        {
            return this.copyrightField;
        }
        set
        {
            this.copyrightField = value;
        }
    }

    /// <remarks/>
    public string Tabber
    {
        get
        {
            return this.tabberField;
        }
        set
        {
            this.tabberField = value;
        }
    }

    /// <remarks/>
    public string Instructions
    {
        get
        {
            return this.instructionsField;
        }
        set
        {
            this.instructionsField = value;
        }
    }

    /// <remarks/>
    public string Notices
    {
        get
        {
            return this.noticesField;
        }
        set
        {
            this.noticesField = value;
        }
    }

    /// <remarks/>
    public string FirstPageHeader
    {
        get
        {
            return this.firstPageHeaderField;
        }
        set
        {
            this.firstPageHeaderField = value;
        }
    }

    /// <remarks/>
    public string FirstPageFooter
    {
        get
        {
            return this.firstPageFooterField;
        }
        set
        {
            this.firstPageFooterField = value;
        }
    }

    /// <remarks/>
    public string PageHeader
    {
        get
        {
            return this.pageHeaderField;
        }
        set
        {
            this.pageHeaderField = value;
        }
    }

    /// <remarks/>
    public string PageFooter
    {
        get
        {
            return this.pageFooterField;
        }
        set
        {
            this.pageFooterField = value;
        }
    }

    /// <remarks/>
    public string ScoreSystemsDefaultLayout { get; set; }

    /// <remarks/>
    public object ScoreSystemsLayout
    {
        get
        {
            return this.scoreSystemsLayoutField;
        }
        set
        {
            this.scoreSystemsLayoutField = value;
        }
    }

    /// <remarks/>
    public string ScoreZoomPolicy
    {
        get
        {
            return this.scoreZoomPolicyField;
        }
        set
        {
            this.scoreZoomPolicyField = value;
        }
    }

    /// <remarks/>
    public string ScoreZoom { get; set; }

    /// <remarks/>
    public string MultiVoice { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFMasterTrack
{

    private string tracksField;

    private GPIFMasterTrackAutomations automationsField;

    private GPIFMasterTrackRSE rSEField;

    /// <remarks/>
    public string Tracks
    {
        get
        {
            return this.tracksField;
        }
        set
        {
            this.tracksField = value;
        }
    }

    /// <remarks/>
    public GPIFMasterTrackAutomations Automations
    {
        get
        {
            return this.automationsField;
        }
        set
        {
            this.automationsField = value;
        }
    }

    /// <remarks/>
    public GPIFMasterTrackRSE RSE
    {
        get
        {
            return this.rSEField;
        }
        set
        {
            this.rSEField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFMasterTrackAutomations
{

    private GPIFMasterTrackAutomationsAutomation automationField;

    /// <remarks/>
    [XmlElement("Automation")]
    public GPIFMasterTrackAutomationsAutomation[] Automation { get; set;}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFMasterTrackAutomationsAutomation
{

    private string typeField;

    private bool linearField;

    private int barField;

    private double positionField;

    private bool visibleField;

    private string valueField;

    /// <remarks/>
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public bool Linear
    {
        get
        {
            return this.linearField;
        }
        set
        {
            this.linearField = value;
        }
    }

    /// <remarks/>
    public int Bar
    {
        get
        {
            return this.barField;
        }
        set
        {
            this.barField = value;
        }
    }

    /// <remarks/>
    public double Position { get; set; }

    /// <remarks/>
    public bool Visible
    {
        get
        {
            return this.visibleField;
        }
        set
        {
            this.visibleField = value;
        }
    }

    /// <remarks/>
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFMasterTrackRSE
{

    private GPIFMasterTrackRSEEffect[] masterField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Effect", IsNullable = false)]
    public GPIFMasterTrackRSEEffect[] Master
    {
        get
        {
            return this.masterField;
        }
        set
        {
            this.masterField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFMasterTrackRSEEffect
{

    private string parametersField;

    private string idField;

    /// <remarks/>
    public string Parameters
    {
        get
        {
            return this.parametersField;
        }
        set
        {
            this.parametersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracks
{

    private GPIFTracksTrack trackField;

    /// <remarks/>
    [XmlElement("Track")]
    public GPIFTracksTrack[] Track { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrack
{

    private string nameField;

    private string shortNameField;

    private string colorField;

    private int systemsDefautLayoutField;

    private string systemsLayoutField;

    private object autoBrushField;

    private decimal palmMuteField;

    private decimal autoAccentuationField;

    private string playingStyleField;

    private object useOneChannelPerStringField;

    private int iconIdField;

    private GPIFTracksTrackInstrumentSet instrumentSetField;

    private GPIFTracksTrackTranspose transposeField;

    private GPIFTracksTrackRSE rSEField;

    private int forcedSoundField;

    private GPIFTracksTrackSounds soundsField;

    private GPIFTracksTrackMidiConnection midiConnectionField;

    private string playbackStateField;

    private string audioEngineStateField;

    private GPIFTracksTrackLyrics lyricsField;

    private GPIFTracksTrackStaves stavesField;

    private GPIFTracksTrackAutomations automationsField;

    private int idField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string ShortName
    {
        get
        {
            return this.shortNameField;
        }
        set
        {
            this.shortNameField = value;
        }
    }

    /// <remarks/>
    public string Color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <remarks/>
    public int SystemsDefautLayout
    {
        get
        {
            return this.systemsDefautLayoutField;
        }
        set
        {
            this.systemsDefautLayoutField = value;
        }
    }

    /// <remarks/>
    public string SystemsLayout
    {
        get
        {
            return this.systemsLayoutField;
        }
        set
        {
            this.systemsLayoutField = value;
        }
    }

    /// <remarks/>
    public object AutoBrush
    {
        get
        {
            return this.autoBrushField;
        }
        set
        {
            this.autoBrushField = value;
        }
    }

    /// <remarks/>
    public decimal PalmMute
    {
        get
        {
            return this.palmMuteField;
        }
        set
        {
            this.palmMuteField = value;
        }
    }

    /// <remarks/>
    public decimal AutoAccentuation
    {
        get
        {
            return this.autoAccentuationField;
        }
        set
        {
            this.autoAccentuationField = value;
        }
    }

    /// <remarks/>
    public string PlayingStyle
    {
        get
        {
            return this.playingStyleField;
        }
        set
        {
            this.playingStyleField = value;
        }
    }

    /// <remarks/>
    public object UseOneChannelPerString
    {
        get
        {
            return this.useOneChannelPerStringField;
        }
        set
        {
            this.useOneChannelPerStringField = value;
        }
    }

    /// <remarks/>
    public int IconId
    {
        get
        {
            return this.iconIdField;
        }
        set
        {
            this.iconIdField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackInstrumentSet InstrumentSet
    {
        get
        {
            return this.instrumentSetField;
        }
        set
        {
            this.instrumentSetField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackTranspose Transpose
    {
        get
        {
            return this.transposeField;
        }
        set
        {
            this.transposeField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackRSE RSE
    {
        get
        {
            return this.rSEField;
        }
        set
        {
            this.rSEField = value;
        }
    }

    /// <remarks/>
    public int ForcedSound
    {
        get
        {
            return this.forcedSoundField;
        }
        set
        {
            this.forcedSoundField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackSounds Sounds
    {
        get
        {
            return this.soundsField;
        }
        set
        {
            this.soundsField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackMidiConnection MidiConnection
    {
        get
        {
            return this.midiConnectionField;
        }
        set
        {
            this.midiConnectionField = value;
        }
    }

    /// <remarks/>
    public string PlaybackState
    {
        get
        {
            return this.playbackStateField;
        }
        set
        {
            this.playbackStateField = value;
        }
    }

    /// <remarks/>
    public string AudioEngineState
    {
        get
        {
            return this.audioEngineStateField;
        }
        set
        {
            this.audioEngineStateField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackLyrics Lyrics
    {
        get
        {
            return this.lyricsField;
        }
        set
        {
            this.lyricsField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackStaves Staves
    {
        get
        {
            return this.stavesField;
        }
        set
        {
            this.stavesField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackAutomations Automations
    {
        get
        {
            return this.automationsField;
        }
        set
        {
            this.automationsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackInstrumentSet
{

    private string nameField;

    private string typeField;

    private int lineCountField;

    private GPIFTracksTrackInstrumentSetElements elementsField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public int LineCount
    {
        get
        {
            return this.lineCountField;
        }
        set
        {
            this.lineCountField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackInstrumentSetElements Elements
    {
        get
        {
            return this.elementsField;
        }
        set
        {
            this.elementsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackInstrumentSetElements
{

    private GPIFTracksTrackInstrumentSetElementsElement elementField;

    /// <remarks/>
    [XmlElement("Element")]
    public GPIFTracksTrackInstrumentSetElementsElement[] Element { get; set; }

}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackInstrumentSetElementsElement
{

    private string nameField;

    private string typeField;

    private object soundbankNameField;

    private GPIFTracksTrackInstrumentSetElementsElementArticulations articulationsField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public object SoundbankName
    {
        get
        {
            return this.soundbankNameField;
        }
        set
        {
            this.soundbankNameField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackInstrumentSetElementsElementArticulations Articulations
    {
        get
        {
            return this.articulationsField;
        }
        set
        {
            this.articulationsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackInstrumentSetElementsElementArticulations
{

    private GPIFTracksTrackInstrumentSetElementsElementArticulationsArticulation articulationField;

    /// <remarks/>
    [XmlElement("Articulation")]
    public GPIFTracksTrackInstrumentSetElementsElementArticulationsArticulation[] Articulation { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackInstrumentSetElementsElementArticulationsArticulation
{

    private object nameField;

    private int staffLineField;

    private string noteheadsField;

    private string techniquePlacementField;

    private object techniqueSymbolField;

    private object inputMidiNumbersField;

    private object outputRSESoundField;

    private int outputMidiNumberField;

    /// <remarks/>
    public object Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public int StaffLine
    {
        get
        {
            return this.staffLineField;
        }
        set
        {
            this.staffLineField = value;
        }
    }

    /// <remarks/>
    public string Noteheads
    {
        get
        {
            return this.noteheadsField;
        }
        set
        {
            this.noteheadsField = value;
        }
    }

    /// <remarks/>
    public string TechniquePlacement
    {
        get
        {
            return this.techniquePlacementField;
        }
        set
        {
            this.techniquePlacementField = value;
        }
    }

    /// <remarks/>
    public object TechniqueSymbol
    {
        get
        {
            return this.techniqueSymbolField;
        }
        set
        {
            this.techniqueSymbolField = value;
        }
    }

    /// <remarks/>
    public object InputMidiNumbers
    {
        get
        {
            return this.inputMidiNumbersField;
        }
        set
        {
            this.inputMidiNumbersField = value;
        }
    }

    /// <remarks/>
    public object OutputRSESound
    {
        get
        {
            return this.outputRSESoundField;
        }
        set
        {
            this.outputRSESoundField = value;
        }
    }

    /// <remarks/>
    public int OutputMidiNumber
    {
        get
        {
            return this.outputMidiNumberField;
        }
        set
        {
            this.outputMidiNumberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackTranspose
{

    private int chromaticField;

    private int octaveField;

    /// <remarks/>
    public int Chromatic
    {
        get
        {
            return this.chromaticField;
        }
        set
        {
            this.chromaticField = value;
        }
    }

    /// <remarks/>
    public int Octave
    {
        get
        {
            return this.octaveField;
        }
        set
        {
            this.octaveField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackRSE
{

    private GPIFTracksTrackRSEChannelStrip channelStripField;

    /// <remarks/>
    public GPIFTracksTrackRSEChannelStrip ChannelStrip
    {
        get
        {
            return this.channelStripField;
        }
        set
        {
            this.channelStripField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackRSEChannelStrip
{

    private string parametersField;

    private GPIFTracksTrackRSEChannelStripAutomation[] automationsField;

    private string versionField;

    /// <remarks/>
    public string Parameters
    {
        get
        {
            return this.parametersField;
        }
        set
        {
            this.parametersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Automation", IsNullable = false)]
    public GPIFTracksTrackRSEChannelStripAutomation[] Automations
    {
        get
        {
            return this.automationsField;
        }
        set
        {
            this.automationsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackRSEChannelStripAutomation
{

    private string typeField;

    private bool linearField;

    private int barField;

    private double positionField;

    private bool visibleField;

    private decimal valueField;

    /// <remarks/>
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public bool Linear
    {
        get
        {
            return this.linearField;
        }
        set
        {
            this.linearField = value;
        }
    }

    /// <remarks/>
    public int Bar
    {
        get
        {
            return this.barField;
        }
        set
        {
            this.barField = value;
        }
    }

    /// <remarks/>
    public double Position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    public bool Visible
    {
        get
        {
            return this.visibleField;
        }
        set
        {
            this.visibleField = value;
        }
    }

    /// <remarks/>
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackSounds
{

    private GPIFTracksTrackSoundsSound soundField;

    /// <remarks/>
    [XmlElement("Sound")]
    public GPIFTracksTrackSoundsSound[] Sound { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackSoundsSound
{

    private string nameField;

    private string labelField;

    private string pathField;

    private string roleField;

    private GPIFTracksTrackSoundsSoundMIDI mIDIField;

    private GPIFTracksTrackSoundsSoundRSE rSEField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    /// <remarks/>
    public string Path
    {
        get
        {
            return this.pathField;
        }
        set
        {
            this.pathField = value;
        }
    }

    /// <remarks/>
    public string Role
    {
        get
        {
            return this.roleField;
        }
        set
        {
            this.roleField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackSoundsSoundMIDI MIDI
    {
        get
        {
            return this.mIDIField;
        }
        set
        {
            this.mIDIField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackSoundsSoundRSE RSE
    {
        get
        {
            return this.rSEField;
        }
        set
        {
            this.rSEField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackSoundsSoundMIDI
{

    private int lSBField;

    private int mSBField;

    private int programField;

    /// <remarks/>
    public int LSB
    {
        get
        {
            return this.lSBField;
        }
        set
        {
            this.lSBField = value;
        }
    }

    /// <remarks/>
    public int MSB
    {
        get
        {
            return this.mSBField;
        }
        set
        {
            this.mSBField = value;
        }
    }

    /// <remarks/>
    public int Program
    {
        get
        {
            return this.programField;
        }
        set
        {
            this.programField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackSoundsSoundRSE
{

    private string soundbankPatchField;

    private object elementsSettingsField;

    private GPIFTracksTrackSoundsSoundRSEPickups pickupsField;

    private GPIFTracksTrackSoundsSoundRSEEffect[] effectChainField;

    /// <remarks/>
    public string SoundbankPatch
    {
        get
        {
            return this.soundbankPatchField;
        }
        set
        {
            this.soundbankPatchField = value;
        }
    }

    /// <remarks/>
    public object ElementsSettings
    {
        get
        {
            return this.elementsSettingsField;
        }
        set
        {
            this.elementsSettingsField = value;
        }
    }

    /// <remarks/>
    public GPIFTracksTrackSoundsSoundRSEPickups Pickups
    {
        get
        {
            return this.pickupsField;
        }
        set
        {
            this.pickupsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Effect", IsNullable = false)]
    public GPIFTracksTrackSoundsSoundRSEEffect[] EffectChain
    {
        get
        {
            return this.effectChainField;
        }
        set
        {
            this.effectChainField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackSoundsSoundRSEPickups
{

    private int overloudPositionField;

    private string volumesField;

    private string tonesField;

    /// <remarks/>
    public int OverloudPosition
    {
        get
        {
            return this.overloudPositionField;
        }
        set
        {
            this.overloudPositionField = value;
        }
    }

    /// <remarks/>
    public string Volumes
    {
        get
        {
            return this.volumesField;
        }
        set
        {
            this.volumesField = value;
        }
    }

    /// <remarks/>
    public string Tones
    {
        get
        {
            return this.tonesField;
        }
        set
        {
            this.tonesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackSoundsSoundRSEEffect
{

    private string parametersField;

    private string idField;

    /// <remarks/>
    public string Parameters
    {
        get
        {
            return this.parametersField;
        }
        set
        {
            this.parametersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackMidiConnection
{

    private int portField;

    private int primaryChannelField;

    private int secondaryChannelField;

    private bool foreOneChannelPerStringField;

    /// <remarks/>
    public int Port
    {
        get
        {
            return this.portField;
        }
        set
        {
            this.portField = value;
        }
    }

    /// <remarks/>
    public int PrimaryChannel
    {
        get
        {
            return this.primaryChannelField;
        }
        set
        {
            this.primaryChannelField = value;
        }
    }

    /// <remarks/>
    public int SecondaryChannel
    {
        get
        {
            return this.secondaryChannelField;
        }
        set
        {
            this.secondaryChannelField = value;
        }
    }

    /// <remarks/>
    public bool ForeOneChannelPerString
    {
        get
        {
            return this.foreOneChannelPerStringField;
        }
        set
        {
            this.foreOneChannelPerStringField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackLyrics
{

    private GPIFTracksTrackLyricsLine[] lineField;

    private bool dispatchedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Line")]
    public GPIFTracksTrackLyricsLine[] Line
    {
        get
        {
            return this.lineField;
        }
        set
        {
            this.lineField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool dispatched
    {
        get
        {
            return this.dispatchedField;
        }
        set
        {
            this.dispatchedField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackLyricsLine
{

    private string textField;

    private int offsetField;

    /// <remarks/>
    public string Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    public int Offset
    {
        get
        {
            return this.offsetField;
        }
        set
        {
            this.offsetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackStaves
{

    private GPIFTracksTrackStavesStaff staffField;

    [XmlElement("Staff")]
    public GPIFTracksTrackStavesStaff[] Staff { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackStavesStaff
{

    private GPIFTracksTrackStavesStaffProperties propertiesField;

    /// <remarks/>
    public GPIFTracksTrackStavesStaffProperties Properties
    {
        get
        {
            return this.propertiesField;
        }
        set
        {
            this.propertiesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackStavesStaffProperties
{

    private GPIFTracksTrackStavesStaffPropertiesProperty[] propertyField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Property")]
    public GPIFTracksTrackStavesStaffPropertiesProperty[] Property
    {
        get
        {
            return this.propertyField;
        }
        set
        {
            this.propertyField = value;
        }
    }

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackStavesStaffPropertiesProperty
{

    private object enableField;

    private object itemsField;

    private string pitchesField;

    private object flatField;

    private string instrumentField;

    private string labelField;

    private bool labelVisibleField;

    private bool labelVisibleFieldSpecified;

    private int bitsetField;

    private bool bitsetFieldSpecified;

    private int numberField;

    private bool numberFieldSpecified;

    private int fretField;

    private bool fretFieldSpecified;

    private string nameField;

    /// <remarks/>
    public object Enable
    {
        get
        {
            return this.enableField;
        }
        set
        {
            this.enableField = value;
        }
    }

    /// <remarks/>
    public object Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    public string Pitches
    {
        get
        {
            return this.pitchesField;
        }
        set
        {
            this.pitchesField = value;
        }
    }

    /// <remarks/>
    public object Flat
    {
        get
        {
            return this.flatField;
        }
        set
        {
            this.flatField = value;
        }
    }

    /// <remarks/>
    public string Instrument
    {
        get
        {
            return this.instrumentField;
        }
        set
        {
            this.instrumentField = value;
        }
    }

    /// <remarks/>
    public string Label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    /// <remarks/>
    public bool LabelVisible
    {
        get
        {
            return this.labelVisibleField;
        }
        set
        {
            this.labelVisibleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LabelVisibleSpecified
    {
        get
        {
            return this.labelVisibleFieldSpecified;
        }
        set
        {
            this.labelVisibleFieldSpecified = value;
        }
    }

    /// <remarks/>
    public int Bitset
    {
        get
        {
            return this.bitsetField;
        }
        set
        {
            this.bitsetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BitsetSpecified
    {
        get
        {
            return this.bitsetFieldSpecified;
        }
        set
        {
            this.bitsetFieldSpecified = value;
        }
    }

    /// <remarks/>
    public int Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NumberSpecified
    {
        get
        {
            return this.numberFieldSpecified;
        }
        set
        {
            this.numberFieldSpecified = value;
        }
    }

    /// <remarks/>
    public int Fret
    {
        get
        {
            return this.fretField;
        }
        set
        {
            this.fretField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FretSpecified
    {
        get
        {
            return this.fretFieldSpecified;
        }
        set
        {
            this.fretFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackAutomations
{

    private GPIFTracksTrackAutomationsAutomation automationField;

    /// <remarks/>
    [XmlElement("Automation")]
    public GPIFTracksTrackAutomationsAutomation[] Automation { get; set; }

}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFTracksTrackAutomationsAutomation
{

    private string typeField;

    private bool linearField;

    private int barField;

    private double positionField;

    private bool visibleField;

    private string valueField;

    /// <remarks/>
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public bool Linear
    {
        get
        {
            return this.linearField;
        }
        set
        {
            this.linearField = value;
        }
    }

    /// <remarks/>
    public int Bar
    {
        get
        {
            return this.barField;
        }
        set
        {
            this.barField = value;
        }
    }

    /// <remarks/>
    public double Position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    public bool Visible
    {
        get
        {
            return this.visibleField;
        }
        set
        {
            this.visibleField = value;
        }
    }

    /// <remarks/>
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFMasterBar
{

    private GPIFMasterBarKey keyField;

    private string timeField;

    private GPIFMasterBarRepeat repeatField;

    private object freeTimeField;

    private object doubleBarField;

    private string barsField;

    /// <remarks/>
    public GPIFMasterBarKey Key
    {
        get
        {
            return this.keyField;
        }
        set
        {
            this.keyField = value;
        }
    }

    /// <remarks/>
    public string Time
    {
        get
        {
            return this.timeField;
        }
        set
        {
            this.timeField = value;
        }
    }

    /// <remarks/>
    public GPIFMasterBarRepeat Repeat
    {
        get
        {
            return this.repeatField;
        }
        set
        {
            this.repeatField = value;
        }
    }

    /// <remarks/>
    public object FreeTime
    {
        get
        {
            return this.freeTimeField;
        }
        set
        {
            this.freeTimeField = value;
        }
    }

    /// <remarks/>
    public object DoubleBar
    {
        get
        {
            return this.doubleBarField;
        }
        set
        {
            this.doubleBarField = value;
        }
    }

    /// <remarks/>
    public string Bars
    {
        get
        {
            return this.barsField;
        }
        set
        {
            this.barsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFMasterBarKey
{

    private int accidentalCountField;

    private string modeField;

    private string transposeAsField;

    /// <remarks/>
    public int AccidentalCount
    {
        get
        {
            return this.accidentalCountField;
        }
        set
        {
            this.accidentalCountField = value;
        }
    }

    /// <remarks/>
    public string Mode
    {
        get
        {
            return this.modeField;
        }
        set
        {
            this.modeField = value;
        }
    }

    /// <remarks/>
    public string TransposeAs
    {
        get
        {
            return this.transposeAsField;
        }
        set
        {
            this.transposeAsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFMasterBarRepeat
{

    private bool startField;

    private bool endField;

    private int countField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool start
    {
        get
        {
            return this.startField;
        }
        set
        {
            this.startField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool end
    {
        get
        {
            return this.endField;
        }
        set
        {
            this.endField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int count
    {
        get
        {
            return this.countField;
        }
        set
        {
            this.countField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFBar
{

    private string clefField;

    private string voicesField;

    private int idField;

    /// <remarks/>
    public string Clef
    {
        get
        {
            return this.clefField;
        }
        set
        {
            this.clefField = value;
        }
    }

    /// <remarks/>
    public string Voices
    {
        get
        {
            return this.voicesField;
        }
        set
        {
            this.voicesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFVoice
{

    private string beatsField;

    private int idField;

    /// <remarks/>
    public string Beats
    {
        get
        {
            return this.beatsField;
        }
        set
        {
            this.beatsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFBeat
{

    private string graceNotesField;

    private string dynamicField;

    private GPIFBeatRhythm rhythmField;

    private string transposedPitchStemOrientationField;

    private string concertPitchStemOrientationField;

    private string arpeggioField;

    private string golpeField;

    private GPIFBeatWhammy whammyField;

    private object deadSlappedField;

    private GPIFBeatLegato legatoField;

    private string tremoloField;

    private string notesField;

    private GPIFBeatProperty[] propertiesField;

    private GPIFBeatXProperty[] xPropertiesField;

    private int idField;

    /// <remarks/>
    public string GraceNotes
    {
        get
        {
            return this.graceNotesField;
        }
        set
        {
            this.graceNotesField = value;
        }
    }

    /// <remarks/>
    public string Dynamic
    {
        get
        {
            return this.dynamicField;
        }
        set
        {
            this.dynamicField = value;
        }
    }

    /// <remarks/>
    public GPIFBeatRhythm Rhythm
    {
        get
        {
            return this.rhythmField;
        }
        set
        {
            this.rhythmField = value;
        }
    }

    /// <remarks/>
    public string TransposedPitchStemOrientation
    {
        get
        {
            return this.transposedPitchStemOrientationField;
        }
        set
        {
            this.transposedPitchStemOrientationField = value;
        }
    }

    /// <remarks/>
    public string ConcertPitchStemOrientation
    {
        get
        {
            return this.concertPitchStemOrientationField;
        }
        set
        {
            this.concertPitchStemOrientationField = value;
        }
    }

    /// <remarks/>
    public string Arpeggio
    {
        get
        {
            return this.arpeggioField;
        }
        set
        {
            this.arpeggioField = value;
        }
    }

    /// <remarks/>
    public string Golpe
    {
        get
        {
            return this.golpeField;
        }
        set
        {
            this.golpeField = value;
        }
    }

    /// <remarks/>
    public GPIFBeatWhammy Whammy
    {
        get
        {
            return this.whammyField;
        }
        set
        {
            this.whammyField = value;
        }
    }

    /// <remarks/>
    public object DeadSlapped
    {
        get
        {
            return this.deadSlappedField;
        }
        set
        {
            this.deadSlappedField = value;
        }
    }

    /// <remarks/>
    public GPIFBeatLegato Legato
    {
        get
        {
            return this.legatoField;
        }
        set
        {
            this.legatoField = value;
        }
    }

    /// <remarks/>
    public string Tremolo
    {
        get
        {
            return this.tremoloField;
        }
        set
        {
            this.tremoloField = value;
        }
    }

    /// <remarks/>
    public string Notes
    {
        get
        {
            return this.notesField;
        }
        set
        {
            this.notesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Property", IsNullable = false)]
    public GPIFBeatProperty[] Properties
    {
        get
        {
            return this.propertiesField;
        }
        set
        {
            this.propertiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("XProperty", IsNullable = false)]
    public GPIFBeatXProperty[] XProperties
    {
        get
        {
            return this.xPropertiesField;
        }
        set
        {
            this.xPropertiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFBeatRhythm
{

    private int refField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int @ref
    {
        get
        {
            return this.refField;
        }
        set
        {
            this.refField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFBeatWhammy
{

    private decimal originValueField;

    private decimal middleValueField;

    private decimal destinationValueField;

    private decimal originOffsetField;

    private decimal middleOffset1Field;

    private decimal middleOffset2Field;

    private decimal destinationOffsetField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal originValue
    {
        get
        {
            return this.originValueField;
        }
        set
        {
            this.originValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal middleValue
    {
        get
        {
            return this.middleValueField;
        }
        set
        {
            this.middleValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal destinationValue
    {
        get
        {
            return this.destinationValueField;
        }
        set
        {
            this.destinationValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal originOffset
    {
        get
        {
            return this.originOffsetField;
        }
        set
        {
            this.originOffsetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal middleOffset1
    {
        get
        {
            return this.middleOffset1Field;
        }
        set
        {
            this.middleOffset1Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal middleOffset2
    {
        get
        {
            return this.middleOffset2Field;
        }
        set
        {
            this.middleOffset2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal destinationOffset
    {
        get
        {
            return this.destinationOffsetField;
        }
        set
        {
            this.destinationOffsetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFBeatLegato
{

    private bool originField;

    private bool destinationField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool origin
    {
        get
        {
            return this.originField;
        }
        set
        {
            this.originField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool destination
    {
        get
        {
            return this.destinationField;
        }
        set
        {
            this.destinationField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFBeatProperty
{

    private object enableField;

    private string strengthField;

    private decimal floatField;

    private bool floatFieldSpecified;

    private string directionField;

    private string nameField;

    /// <remarks/>
    public object Enable
    {
        get
        {
            return this.enableField;
        }
        set
        {
            this.enableField = value;
        }
    }

    /// <remarks/>
    public string Strength
    {
        get
        {
            return this.strengthField;
        }
        set
        {
            this.strengthField = value;
        }
    }

    /// <remarks/>
    public decimal Float
    {
        get
        {
            return this.floatField;
        }
        set
        {
            this.floatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FloatSpecified
    {
        get
        {
            return this.floatFieldSpecified;
        }
        set
        {
            this.floatFieldSpecified = value;
        }
    }

    /// <remarks/>
    public string Direction
    {
        get
        {
            return this.directionField;
        }
        set
        {
            this.directionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFBeatXProperty
{

    private double floatField;

    private bool floatFieldSpecified;

    private int intField;

    private bool intFieldSpecified;

    private uint idField;

    /// <remarks/>
    public double Float
    {
        get
        {
            return this.floatField;
        }
        set
        {
            this.floatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FloatSpecified
    {
        get
        {
            return this.floatFieldSpecified;
        }
        set
        {
            this.floatFieldSpecified = value;
        }
    }

    /// <remarks/>
    public int Int
    {
        get
        {
            return this.intField;
        }
        set
        {
            this.intField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IntSpecified
    {
        get
        {
            return this.intFieldSpecified;
        }
        set
        {
            this.intFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFNote
{

    private object letRingField;

    private int accentField;

    private bool accentFieldSpecified;

    private string antiAccentField;

    private string vibratoField;

    private GPIFNoteTie tieField;

    private string ornamentField;

    private int trillField;

    private bool trillFieldSpecified;

    private int velocityField;

    private bool velocityFieldSpecified;

    private int instrumentArticulationField;

    private GPIFNoteProperty[] propertiesField;

    private GPIFNoteXProperties xPropertiesField;

    private int idField;

    /// <remarks/>
    public object LetRing
    {
        get
        {
            return this.letRingField;
        }
        set
        {
            this.letRingField = value;
        }
    }

    /// <remarks/>
    public int Accent
    {
        get
        {
            return this.accentField;
        }
        set
        {
            this.accentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AccentSpecified
    {
        get
        {
            return this.accentFieldSpecified;
        }
        set
        {
            this.accentFieldSpecified = value;
        }
    }

    /// <remarks/>
    public string AntiAccent
    {
        get
        {
            return this.antiAccentField;
        }
        set
        {
            this.antiAccentField = value;
        }
    }

    /// <remarks/>
    public string Vibrato
    {
        get
        {
            return this.vibratoField;
        }
        set
        {
            this.vibratoField = value;
        }
    }

    /// <remarks/>
    public GPIFNoteTie Tie
    {
        get
        {
            return this.tieField;
        }
        set
        {
            this.tieField = value;
        }
    }

    /// <remarks/>
    public string Ornament
    {
        get
        {
            return this.ornamentField;
        }
        set
        {
            this.ornamentField = value;
        }
    }

    /// <remarks/>
    public int Trill
    {
        get
        {
            return this.trillField;
        }
        set
        {
            this.trillField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TrillSpecified
    {
        get
        {
            return this.trillFieldSpecified;
        }
        set
        {
            this.trillFieldSpecified = value;
        }
    }

    /// <remarks/>
    public int Velocity
    {
        get
        {
            return this.velocityField;
        }
        set
        {
            this.velocityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VelocitySpecified
    {
        get
        {
            return this.velocityFieldSpecified;
        }
        set
        {
            this.velocityFieldSpecified = value;
        }
    }

    /// <remarks/>
    public int InstrumentArticulation
    {
        get
        {
            return this.instrumentArticulationField;
        }
        set
        {
            this.instrumentArticulationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Property", IsNullable = false)]
    public GPIFNoteProperty[] Properties
    {
        get
        {
            return this.propertiesField;
        }
        set
        {
            this.propertiesField = value;
        }
    }

    /// <remarks/>
    public GPIFNoteXProperties XProperties
    {
        get
        {
            return this.xPropertiesField;
        }
        set
        {
            this.xPropertiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFNoteTie
{

    private bool originField;

    private bool destinationField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool origin
    {
        get
        {
            return this.originField;
        }
        set
        {
            this.originField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool destination
    {
        get
        {
            return this.destinationField;
        }
        set
        {
            this.destinationField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFNoteProperty
{

    private int flagsField;

    private bool flagsFieldSpecified;

    private decimal floatField;

    private bool floatFieldSpecified;

    private string hTypeField;

    private decimal hFretField;

    private bool hFretFieldSpecified;

    private object enableField;

    private int stringField;

    private bool stringFieldSpecified;

    private int numberField;

    private bool numberFieldSpecified;

    private int fretField;

    private bool fretFieldSpecified;

    private GPIFNotePropertyPitch pitchField;

    private string nameField;

    /// <remarks/>
    public int Flags
    {
        get
        {
            return this.flagsField;
        }
        set
        {
            this.flagsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FlagsSpecified
    {
        get
        {
            return this.flagsFieldSpecified;
        }
        set
        {
            this.flagsFieldSpecified = value;
        }
    }

    /// <remarks/>
    public decimal Float
    {
        get
        {
            return this.floatField;
        }
        set
        {
            this.floatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FloatSpecified
    {
        get
        {
            return this.floatFieldSpecified;
        }
        set
        {
            this.floatFieldSpecified = value;
        }
    }

    /// <remarks/>
    public string HType
    {
        get
        {
            return this.hTypeField;
        }
        set
        {
            this.hTypeField = value;
        }
    }

    /// <remarks/>
    public decimal HFret
    {
        get
        {
            return this.hFretField;
        }
        set
        {
            this.hFretField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool HFretSpecified
    {
        get
        {
            return this.hFretFieldSpecified;
        }
        set
        {
            this.hFretFieldSpecified = value;
        }
    }

    /// <remarks/>
    public object Enable
    {
        get
        {
            return this.enableField;
        }
        set
        {
            this.enableField = value;
        }
    }

    /// <remarks/>
    public int String
    {
        get
        {
            return this.stringField;
        }
        set
        {
            this.stringField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool StringSpecified
    {
        get
        {
            return this.stringFieldSpecified;
        }
        set
        {
            this.stringFieldSpecified = value;
        }
    }

    /// <remarks/>
    public int Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NumberSpecified
    {
        get
        {
            return this.numberFieldSpecified;
        }
        set
        {
            this.numberFieldSpecified = value;
        }
    }

    /// <remarks/>
    public int Fret
    {
        get
        {
            return this.fretField;
        }
        set
        {
            this.fretField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FretSpecified
    {
        get
        {
            return this.fretFieldSpecified;
        }
        set
        {
            this.fretFieldSpecified = value;
        }
    }

    /// <remarks/>
    public GPIFNotePropertyPitch Pitch
    {
        get
        {
            return this.pitchField;
        }
        set
        {
            this.pitchField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFNotePropertyPitch
{

    private string stepField;

    private string accidentalField;

    private int octaveField;

    /// <remarks/>
    public string Step
    {
        get
        {
            return this.stepField;
        }
        set
        {
            this.stepField = value;
        }
    }

    /// <remarks/>
    public string Accidental
    {
        get
        {
            return this.accidentalField;
        }
        set
        {
            this.accidentalField = value;
        }
    }

    /// <remarks/>
    public int Octave
    {
        get
        {
            return this.octaveField;
        }
        set
        {
            this.octaveField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFNoteXProperties
{

    private GPIFNoteXPropertiesXProperty xPropertyField;

    [XmlElement("XProperty")]
    public GPIFNoteXPropertiesXProperty[] XProperty { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFNoteXPropertiesXProperty
{

    private int intField;

    private uint idField;

    /// <remarks/>
    public int Int { get; set; }

    public double Float { get; set; }

    /// <remarks/>
    [XmlAttribute]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFRhythm
{

    private string noteValueField;

    private GPIFRhythmAugmentationDot augmentationDotField;

    private GPIFRhythmPrimaryTuplet primaryTupletField;

    private int idField;

    /// <remarks/>
    public string NoteValue
    {
        get
        {
            return this.noteValueField;
        }
        set
        {
            this.noteValueField = value;
        }
    }

    /// <remarks/>
    public GPIFRhythmAugmentationDot AugmentationDot
    {
        get
        {
            return this.augmentationDotField;
        }
        set
        {
            this.augmentationDotField = value;
        }
    }

    /// <remarks/>
    public GPIFRhythmPrimaryTuplet PrimaryTuplet
    {
        get
        {
            return this.primaryTupletField;
        }
        set
        {
            this.primaryTupletField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFRhythmAugmentationDot
{

    private int countField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int count
    {
        get
        {
            return this.countField;
        }
        set
        {
            this.countField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFRhythmPrimaryTuplet
{

    private int numField;

    private int denField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int num
    {
        get
        {
            return this.numField;
        }
        set
        {
            this.numField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int den
    {
        get
        {
            return this.denField;
        }
        set
        {
            this.denField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GPIFScoreView
{

    private int idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}