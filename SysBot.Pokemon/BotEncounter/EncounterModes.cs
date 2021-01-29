namespace SysBot.Pokemon
{
    public enum EncounterMode
    {
        /// <summary>
        /// Bot will move back and forth in a straight vertical path to encounter Pokémon
        /// </summary>
        VerticalLine,

        /// <summary>
        /// Bot will move back and forth in a straight horizontal path to encounter Pokémon
        /// </summary>
        HorizontalLine,

        /// <summary>
        /// Bot will soft reset Eternatus.
        /// </summary>
        Eternatus,

        /// <summary>
        /// Bot will soft reset Regi Titans.
        /// </summary>
        Regi,

        /// <summary>
        /// Bot will soft reset Regigigas.
        /// </summary>
        Giga,

        /// <summary>
        /// Bot will soft reset Galarian Articuno and Galarian Zapdos.
        /// </summary>
        IceThunder,

        /// <summary>
        /// Bot will soft reset the Legendary Dogs
        /// </summary>
        LegendaryDogs,
    }
}