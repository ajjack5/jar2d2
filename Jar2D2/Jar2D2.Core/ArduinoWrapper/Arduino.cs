using ArduinoDriver.SerialProtocol;
using ArduinoUploader.Hardware;

namespace Jar2D2.Core.ArduinoWrapper
{
  public class Arduino : IArduino
  {
    private readonly ArduinoDriver.ArduinoDriver Driver;

    public Arduino()
    {
      Driver = new ArduinoDriver.ArduinoDriver(ArduinoModel.UnoR3, "COM3", true);
    }

    public AnalogReadResponse Send(AnalogReadRequest request)
    {
      return Driver.Send(request);
    }

    public AnalogWriteResponse Send(AnalogWriteRequest request)
    {
      return Driver.Send(request);
    }

    public DigitalReadResponse Send(DigitalReadRequest request)
    {
      return Driver.Send(request);
    }

    public DigitalWriteReponse Send(DigitalWriteRequest request)
    {
      return Driver.Send(request);
    }

    public PinModeResponse Send(PinModeRequest request)
    {
      return Driver.Send(request);
    }

    public ToneResponse Send(ToneRequest request)
    {
      return Driver.Send(request);
    }

    public NoToneResponse Send(NoToneRequest request)
    {
      return Driver.Send(request);
    }

    public AnalogReferenceResponse Send(AnalogReferenceRequest request)
    {
      return Driver.Send(request);
    }

    public ShiftOutResponse Send(ShiftOutRequest request)
    {
      return Driver.Send(request);
    }

    public ShiftInResponse Send(ShiftInRequest request)
    {
      return Driver.Send(request);
    }
  }
}
