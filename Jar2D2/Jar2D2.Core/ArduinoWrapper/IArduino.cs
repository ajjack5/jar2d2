using ArduinoDriver.SerialProtocol;

namespace Jar2D2.Core.ArduinoWrapper
{
  public interface IArduino
  {
    AnalogReadResponse Send(AnalogReadRequest request);
    AnalogWriteResponse Send(AnalogWriteRequest request);
    DigitalReadResponse Send(DigitalReadRequest request);
    DigitalWriteReponse Send(DigitalWriteRequest request);
    PinModeResponse Send(PinModeRequest request);
    ToneResponse Send(ToneRequest request);
    NoToneResponse Send(NoToneRequest request);
    AnalogReferenceResponse Send(AnalogReferenceRequest request);
    ShiftOutResponse Send(ShiftOutRequest request);
    ShiftInResponse Send(ShiftInRequest request);
  }
}
