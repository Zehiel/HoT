using System.Threading.Tasks;
using IoTDriver.Models;
namespace IoTDriver
{
	public interface IAzureIoTService
	{
		Device[] GetDevicesByUserId(int userId);
		Device GetDeviceByDeviceId(int deviceId);
		string GetValueBySensorName(int deviceId, string sensorName);
		Task SetValueBySensorName(string sensorName);
	}
}
