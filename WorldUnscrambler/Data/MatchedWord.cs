namespace WorldUnscrambler.Data
{
    /// <summary>
    /// We change class for struct because this element categorize variables together that made sense
    /// soon this is not a class but is a struct.
    /// 
    /// Look the name the element(struct) and de properties. They are not similar a an class.
    /// 
    /// Struct is value types soon we need attention because  the stack is small than heap.
    /// If the word list is big(50 elements or more) we need change this element for class.
    /// </summary>
    public struct MatchedWord
    {
        public string ScrambledWord { get;  set; }
        public string Word { get;  set; }
    }
}
