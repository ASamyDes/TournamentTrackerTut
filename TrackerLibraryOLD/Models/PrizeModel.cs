namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// the unique identifier for the prize
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Placement Number (int) for prizes
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Placement Names that corelates to the placement number
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// the Amount of the prize in money (decimal)
        /// </summary>
        public decimal  PrizeAmount{ get; set; }
        /// <summary>
        /// Prizes can also be by percentage of the prize pool
        /// </summary>
        public double PrizePercentage{ get; set; }



        public PrizeModel()
        {

        }

        /// <summary>
        /// Adds the Values by hardCoding it (test Purposes only)
        /// </summary>
        /// <param name="placeName">Placement name strings only</param>
        /// <param name="placeNumber"> Placement number value converts to int</param>
        /// <param name="prizeAmount">Placement prize ammount converts to Decimal</param>
        /// <param name="prizePercentage"> Prize percentage converts to double</param>
        public PrizeModel(string placeName,string placeNumber,string prizeAmount,string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }
        
    }
}