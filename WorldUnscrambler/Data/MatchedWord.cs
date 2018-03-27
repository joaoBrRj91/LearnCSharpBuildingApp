namespace WorldUnscrambler.Data
{
    /// <summary>
    /// We change class for struct because this element categorize variables together that made sense
    /// soon this is not a class but is a struct.
    /// 
    /// Look the name the element and de properties. They are not similar a an class
    /// </summary>
    public struct MatchedWord
    {
        public string ScrambledWord { get;  set; }
        public string Word { get;  set; }
    }
}
