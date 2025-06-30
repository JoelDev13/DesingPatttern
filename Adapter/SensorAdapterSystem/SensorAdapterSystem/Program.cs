using SensorAdapterSystem;

public class Program
{
    public static void Main(string[] args)
    {
        var sensorTemperatura = new SensorTemperatura()
        {
            temperaturaCelsius = 30.2
        };
        var sensorPresion = new SensorPresion()
        {
            presion = 10
        };

        ISensor adaptadorTemp = new AdaptadorSensorTemperatura(sensorTemperatura);
        ISensor adaptadorPresion = new AdaptadorSensorPresion(sensorPresion);

        adaptadorPresion.MostrarDatos();
        adaptadorTemp.MostrarDatos();
    }
}
