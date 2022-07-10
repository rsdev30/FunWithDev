namespace Fun.With.Dev.Anagrams.Contracts
{
    public interface IAnagramsCheck<TInput, TInput2>
    {
        bool IsAnagram(TInput input1, TInput2 input2);
    }
}