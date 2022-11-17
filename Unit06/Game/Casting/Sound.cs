namespace Unit06.Game.Casting
{
    /// <summary>
    /// An sound.
    /// </summary>
    public class Sound
    {
        private string _filename;
        private int _volume;
        private bool _repeated;
        
        /// <summary>
        /// Constructs a new instance of Image.
        /// </summary>
        public Sound(string filename, int volume = 1, bool repeated = false)
        {
            _filename = filename;
            _volume = volume;
            _repeated = repeated;
        }

        /// <summary>
        /// Gets the filename.
        /// </summary>
        /// <returns>The filename.</returns>
        public string GetFilename()
        {
            return _filename;
        }

        /// <summary>
        /// Gets the volume.
        /// </summary>
        /// <returns>The volume.</returns>
        public int GetVolume()
        {
            return _volume;
        }

        /// <summary>
        /// Whether or not the sound should be repeated.
        /// </summary>
        /// <returns>True if the sound should be repeated; false if otherwise.</returns>
        public bool IsRepeated()
        {
            return _repeated;
        }
        
    }
}