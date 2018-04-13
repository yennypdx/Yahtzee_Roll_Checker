namespace YahtzeeRollChecker
{
    interface IRollChecker
    {
        /// <summary>
        /// 	Roll contains 5 die
        /// </summary>
        /// <param name="roll"></param>
        /// <returns></returns>
        bool IsValidRoll(IRoll roll);

        /// <summary>
        /// Three (or more) dice with the same number
        /// </summary>
        /// <param name="roll"></param>
        /// <returns></returns>
        bool IsThreeOfAKind(IRoll roll);

        /// <summary>
        ///  Four (or more) dice with the same number
        /// </summary>
        /// <param name="roll"></param>
        /// <returns></returns>
        bool IsFourOfAKind(IRoll roll);

        /// <summary>
        /// Three dice with matching numbers and the other two dice with matching numbers
        /// </summary>
        /// <param name="roll"></param>
        /// <returns></returns>
        bool IsFullHouse(IRoll roll);

        /// <summary>
        /// At least four of the dice are in consecutive numerical order (remember that order doesn’t matter)
        /// </summary>
        /// <param name="roll"></param>
        /// <returns></returns>
        bool IsSmallStraight(IRoll roll);

        /// <summary>
        /// All five of the dice are in consecutive numerical order (note that the only possible combinations are 1,2,3,4,5 and 2,3,4,5,6; of course the order doesn’t matter)
        /// </summary>
        /// <param name="roll"></param>
        /// <returns></returns>
        bool IsLargeStraight(IRoll roll);

        /// <summary>
        /// All five dice are the same (five of a kind)
        /// </summary>
        /// <param name="roll"></param>
        /// <returns></returns>
        bool IsYahtzee(IRoll roll);

        /// <summary>
        /// Any combination
        /// </summary>
        /// <param name="roll"></param>
        /// <returns></returns>
        bool IsChance(IRoll roll);

        /// <summary>
        /// Get the points for a roll
        /// </summary>
        /// <param name="roll">roll</param>
        /// <returns>Points for the roll</returns>
        int GetRollPoints(IRoll roll);

        /// <summary>
        /// Compare two rolls based on points
        /// </summary>
        /// <param name="roll1">Roll 1</param>
        /// <param name="roll2">Roll 2</param>
        /// <returns>-1 if roll 1 less than roll 2, 0 if they are the same, 1 if roll 1 is greater than roll2</returns>
        int CompareRolls(IRoll roll1, IRoll roll2);


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int fake();
    }
}
