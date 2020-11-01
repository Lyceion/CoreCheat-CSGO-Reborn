using System;
using System.Collections.Generic;
using System.Threading;

namespace MusicsLib
{
    /// <summary>
    /// MUSIC LIB
    /// by Septillioner
    /// https://github.com/septillioner
    /// </summary>
    /// 
    public static class Notes
    {
        public const float Silence = 0f;
        public const float C0 = 16.35f;
        public const float C_0 = 17.32f;
        public const float D0 = 18.35f;
        public const float D_0 = 19.45f;
        public const float E0 = 20.60f;
        public const float F0 = 21.83f;
        public const float F_0 = 23.12f;
        public const float G0 = 24.50f;
        public const float G_0 = 25.96f;
        public const float A0 = 27.50f;
        public const float A_0 = 29.14f;
        public const float B0 = 30.87f;
        public const float C1 = 32.70f;
        public const float C_1 = 34.65f;
        public const float D1 = 36.71f;
        public const float D_1 = 38.89f;
        public const float E1 = 41.20f;
        public const float F1 = 43.65f;
        public const float F_1 = 46.25f;
        public const float G1 = 49.00f;
        public const float G_1 = 51.91f;
        public const float A1 = 55.00f;
        public const float A_1 = 58.27f;
        public const float B1 = 61.74f;
        public const float C2 = 65.41f;
        public const float C_2 = 69.30f;
        public const float D2 = 73.42f;
        public const float D_2 = 77.78f;
        public const float E2 = 82.41f;
        public const float F2 = 87.31f;
        public const float F_2 = 92.50f;
        public const float G2 = 98.00f;
        public const float G_2 = 103.83f;
        public const float A2 = 110.00f;
        public const float A_2 = 116.54f;
        public const float B2 = 123.47f;
        public const float C3 = 130.81f;
        public const float C_3 = 138.59f;
        public const float D3 = 146.83f;
        public const float D_3 = 155.56f;
        public const float E3 = 164.81f;
        public const float F3 = 174.61f;
        public const float F_3 = 185.00f;
        public const float G3 = 196.00f;
        public const float G_3 = 207.65f;
        public const float A3 = 220.00f;
        public const float A_3 = 233.08f;
        public const float B3 = 246.94f;
        public const float C4 = 261.63f;
        public const float C_4 = 277.18f;
        public const float D4 = 293.66f;
        public const float D_4 = 311.13f;
        public const float E4 = 329.63f;
        public const float F4 = 349.23f;
        public const float F_4 = 369.99f;
        public const float G4 = 392.00f;
        public const float G_4 = 415.30f;
        public const float A4 = 440.00f;
        public const float A_4 = 466.16f;
        public const float B4 = 493.88f;
        public const float C5 = 523.25f;
        public const float C_5 = 554.37f;
        public const float D5 = 587.33f;
        public const float D_5 = 622.25f;
        public const float E5 = 659.25f;
        public const float F5 = 698.46f;
        public const float F_5 = 739.99f;
        public const float G5 = 783.99f;
        public const float G_5 = 830.61f;
        public const float A5 = 880.00f;
        public const float A_5 = 932.33f;
        public const float B5 = 987.77f;
        public const float C6 = 1046.50f;
        public const float C_6 = 1108.73f;
        public const float D6 = 1174.66f;
        public const float D_6 = 1244.51f;
        public const float E6 = 1318.51f;
        public const float F6 = 1396.91f;
        public const float F_6 = 1479.98f;
        public const float G6 = 1567.98f;
        public const float G_6 = 1661.22f;
        public const float A6 = 1760.00f;
        public const float A_6 = 1864.66f;
        public const float B6 = 1975.53f;
        public const float C7 = 2093.00f;
        public const float C_7 = 2217.46f;
        public const float D7 = 2349.32f;
        public const float D_7 = 2489.02f;
        public const float E7 = 2637.02f;
        public const float F7 = 2793.83f;
        public const float F_7 = 2959.96f;
        public const float G7 = 3135.96f;
        public const float G_7 = 3322.44f;
        public const float A7 = 3520.00f;
        public const float A_7 = 3729.31f;
        public const float B7 = 3951.07f;
        public const float C8 = 4186.01f;
        public const float C_8 = 4434.92f;
        public const float D8 = 4698.63f;
        public const float D_8 = 4978.03f;
        public const float E8 = 5274.04f;
        public const float F8 = 5587.65f;
        public const float F_8 = 5919.91f;
        public const float G8 = 6271.93f;
        public const float G_8 = 6644.88f;
        public const float A8 = 7040.00f;
        public const float A_8 = 7458.62f;
        public const float B8 = 7902.13f;
    }
    struct Note
    {
        public ushort Duration;
        public ushort Freq;
        public Note(float freq, int duration)
        {
            Freq = (ushort)freq;
            Duration = (ushort)duration;
        }
        public Note(float freq)
        {
            Freq = (ushort)freq;
            Duration = 1;
        }
        public bool IsHearable()
        {
            return Freq != Notes.Silence;
        }
    }
    class MusicLib
    {
        public static List<Note> KurtlarVadisi = new List<Note>{
                new Note(Notes.A5,150),
                new Note(Notes.A5,150),
                new Note(Notes.A5,150),
                new Note(Notes.B5,150),
                new Note(Notes.B5,150),
                new Note(Notes.B5,150),
                new Note(Notes.C6,150),
                new Note(Notes.C6,150),
                new Note(Notes.C6,150),
                new Note(Notes.B5,150),
                new Note(Notes.B5,150),
                new Note(Notes.B5,150),
                new Note(Notes.A5,150),
                new Note(Notes.A5,150),
                new Note(Notes.A5,150),
                new Note(Notes.B5,150),
                new Note(Notes.B5,150),
                new Note(Notes.B5,150),
                new Note(Notes.G5,150),
                new Note(Notes.G5,150),
                new Note(Notes.G5,150),
                new Note(Notes.A5,450)
            };
        private float Speed = 1;
        public void SetSpeed(float speed)
        {
            Speed = speed;
        }
        public static void EngineRun(List<Note> music)
        {
            foreach (Note note in music)
            {
                if (note.IsHearable())
                    Console.Beep(note.Freq, note.Duration);
                else
                    Thread.Sleep(note.Duration);
            }
        }
    }
}