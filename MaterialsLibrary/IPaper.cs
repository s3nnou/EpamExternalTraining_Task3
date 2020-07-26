namespace MaterialsLibrary
{
    /// <summary>
    /// Interface for a Film Figures
    /// </summary>
    public interface IPaper
    {
        Color Color { get; set; }
        bool IsColoredAgain { get; set; }
        void Paint(Color color);
    }
}
