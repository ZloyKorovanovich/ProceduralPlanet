using ComputeWorkflow.Handler;
using Planet.Configuration;

public class HeightMapParametres : Parametres
{
    private const string _RESOLUTION = "Resolution";
    private const string _OCTAVES = "Octaves";
    private const string _SCALE = "Scale";
    private const string _LACUNARITY = "Lacunarity";
    private const string _PERSISTANCE = "Persistance";
    private const string _SEED = "Seed";

    private int _resolution;
    private int _octaves;
    private float _scale;
    private float _lacunarity;
    private float _persistance;
    private float _seed;

    public HeightMapParametres(General general, Landscape landscape, TextureMap heightMap)
    {
        _resolution = heightMap.Resolution;

        _octaves = landscape.Octaves;
        _lacunarity = landscape.Lacunarity;
        _persistance = landscape.Prsistance;
        _seed = landscape.Seed;

        _scale = landscape.Scale * general.Radius;
    }

    public override void ToCompute()
    {
        _convoy.Compute.SetInt(_RESOLUTION, _resolution);
        _convoy.Compute.SetInt(_OCTAVES, _octaves);

        _convoy.Compute.SetFloat(_LACUNARITY, _lacunarity);
        _convoy.Compute.SetFloat(_PERSISTANCE, _persistance);
        _convoy.Compute.SetFloat(_SCALE, _scale);
        _convoy.Compute.SetFloat(_SEED, _seed);
    }
}
