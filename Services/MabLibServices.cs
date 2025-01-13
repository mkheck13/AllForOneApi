namespace AllForOneApi.Services
{
    public class MabLibServices
    {
        public string mabLib(string age, string familyRelation, string job, string stageOfLife, string thing, string size, string humanSettlment, string toyBrand, string profession, string celestialBody)
        {
            return $"There once was a {age} man who didnt know his {familyRelation}.\nHe was told his whole life what a great {job} his {familyRelation} was.\nOne day he met a couple of {thing}'s that were looking for a {stageOfLife} man.\nThe {age} man knew of this {stageOfLife} man and where to find him.\nAfter meeting up with the {stageOfLife} man they all headed to the {size} {humanSettlment} near by to find a spaceship to hire.\nUpon entering the {humanSettlment} they began looking for {job} to hire.\nThe {job} was a scruffy {toyBrand} {profession}, but agreed to fly them where they needed to go.\nThus begins the tale of {celestialBody} Wars.";
        }
    }
}