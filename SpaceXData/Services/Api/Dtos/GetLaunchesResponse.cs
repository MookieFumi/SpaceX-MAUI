namespace SpaceXData.Services.Dtos
{
    public record GetLaunchesResponse (int Year, List<Launch> Launches);
}