//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace mscl {

public class InertialTypes : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal InertialTypes(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InertialTypes obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~InertialTypes() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_InertialTypes(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public InertialTypes() : this(msclPINVOKE.new_InertialTypes(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum VehicleModeType {
    PORTABLE_VEHICLE = 0x01,
    AUTOMOTIVE_VEHICLE = 0x02,
    AIRBORNE_VEHICLE = 0x03,
    AIRBORNE_HIGH_G_VEHICLE = 0x4
  }

  public enum GPSDynamicsMode {
    GPS_PORTABLE = 0x00,
    GPS_STATIONARY = 0x02,
    GPS_PEDESTRIAN = 0x03,
    GPS_AUTOMOTIVE = 0x04,
    GPS_SEA = 0x05,
    GPS_AIRBORNE_1G = 0x06,
    GPS_AIRBORNE_2G = 0x07,
    GPS_AIRBORNE_4G = 0x08
  }

  public enum AxisBitfieldValues {
    RESET_ALL_AXIS = 0x00,
    TARE_ROLL_AXIS = 0x01,
    TARE_PITCH_AXIS = 0x02,
    TARE_YAW_AXIS = 0x04
  }

  public enum GNSS_Source {
    INTERNAL_GNSS = 0x01,
    EXTERNAL_GNSS = 0x02
  }

  public enum GnssFixFlags {
    FIX_SBAS_CORRECTIONS = 0x0001,
    FIX_DGNSS_CORRECTIONS = 0x0002
  }

  public enum GnssFixType {
    FIXTYPE_3D = 0x00,
    FIXTYPE_2D = 0x01,
    FIXTYPE_TIMEONLY = 0x02,
    FIXTYPE_NONE = 0x03,
    FIXTYPE_INVALID = 0x04,
    FIXTYPE_RTK_FLOAT = 0x05,
    FIXTYPE_RTK_FIXED = 0x06
  }

  public enum DualAntennaFixType {
    FIXTYPE_DUAL_ANTENNA_NONE = 0x00,
    FIXTYPE_DUAL_ANTENNA_FLOAT = 0x01,
    FIXTYPE_DUAL_ANTENNA_FIXED = 0x02
  }

  public enum DualAntennaStatusFlags {
    DATA_VALID_REC_1 = 0x01,
    DATA_VALID_REC_2 = 0x02,
    ANTENNA_OFFSETS_VALID = 0x04
  }

  public enum SpaceVehicleFlags {
    SVFLAG_NAVIGATION = 0x0001,
    SVFLAG_HEALTHY = 0x0002
  }

  public enum DeviceSelector {
    DEVICE_AHRS = 0x01,
    DEVICE_GPS = 0x02
  }

  public enum PowerState {
    ON_FULL_PERFORMANCE = 0x01,
    ON_LOW_POWER = 0x02,
    SLEEP = 0x03,
    OFF = 0x04
  }

  public enum StreamFormat {
    STANDARD_MIP = 0x01,
    WRAPPED_RAW = 0x02
  }

  public enum SensorState {
    SENSORSTATE_OFF = 0x00,
    SENSORSTATE_ON = 0x01,
    SENSORSTATE_UNKNOWN = 0x02
  }

  public enum AntennaState {
    ANTENNASTATE_INIT = 0x01,
    ANTENNASTATE_SHORT = 0x02,
    ANTENNASTATE_OPEN = 0x03,
    ANTENNASTATE_GOOD = 0x04,
    ANTENNASTATE_UNKNOWN = 0x05
  }

  public enum AntennaPower {
    ANTENNAPOWER_OFF = 0x00,
    ANTENNAPOWER_ON = 0x01,
    ANTENNAPOWER_UNKNOWN = 0x02
  }

  public enum FilterState {
    FILTERSTATE_STARTUP = 0x00,
    FILTERSTATE_INIT = 0x01,
    FILTERSTATE_RUNNING_SLN_VALID = 0x02,
    FILTERSTATE_RUNNING_SLN_ERROR = 0x03,
    FILTERSTATE_VERT_GYRO = 0x02,
    FILTERSTATE_AHRS = 0x03,
    FILTERSTATE_FULL_NAV = 0x04
  }

  public enum FilterStatus_Running {
    FILTERSTATUS_IMU_UNAVAILABLE = 0x0001,
    FILTERSTATUS_GPS_UNAVAILABLE = 0x0002,
    FILTERSTATUS_MATRIX_SINGULARITY_IN_CALC = 0x0008,
    FILTERSTATUS_POS_COVARIANCE_HIGH_WARN = 0x0010,
    FILTERSTATUS_VEL_COVARIANCE_HIGH_WARN = 0x0020,
    FILTERSTATUS_ATT_COVARIANCE_HIGH_WARN = 0x0040,
    FILTERSTATUS_NAN_IN_SOLUTION = 0x0080,
    FILTERSTATUS_GYRO_BIAS_EST_HIGH_WARN = 0x0100,
    FILTERSTATUS_ACCEL_BIAS_EST_HIGH_WARN = 0x0200,
    FILTERSTATUS_GYRO_SCALE_FACTOR_EST_HIGH_WARN = 0x0400,
    FILTERSTATUS_ACCEL_SCALE_FACTOR_EST_HIGH_WARN = 0x0800,
    FILTERSTATUS_MAG_BIAS_EST_HIGH_WARN = 0x1000,
    FILTERSTATUS_ANTENNA_OFFSET_CORRECTION_EST_HIGH_WARN = 0x2000,
    FILTERSTATUS_HARD_IRON_OFFSET_EST_HIGH_WARN = 0x4000,
    FILTERSTATUS_SOFT_IRON_CORRECTION_EST_HIGH_WARN = 0x8000,
    FILTERSTATUS_CONDITION = 0x0003,
    FILTERSTATUS_ROLL_PITCH_WARNING = 0x0004,
    FILTERSTATUS_HEADING_WARNING = 0x0008,
    FILTERSTATUS_POSITION_WARNING = 0x0010,
    FILTERSTATUS_VELOCITY_WARNING = 0x0020,
    FILTERSTATUS_IMU_BIAS_WARNING = 0x0040,
    FILTERSTATUS_GNSS_CLK_WARNING = 0x0080,
    FILTERSTATUS_ANT_LEVER_ARM_WARNING = 0x0100,
    FILTERSTATUS_MOUNTING_TRANSFORM_WARNING = 0x0200
  }

  public enum FilterStatus_Initialization {
    FILTERSTATUS_ATT_NOT_INIT = 0x1000,
    FILTERSTATUS_POS_VEL_NOT_INIT = 0x2000
  }

  public enum FilterCondition {
    STABLE = 0x01,
    CONVERGING = 0x02,
    UNSTABLE = 0x03
  }

  public enum DgnssBaseStatus {
    DGNSSBASE_UDRE_SCALE_FACTOR_1_00 = 0,
    DGNSSBASE_UDRE_SCALE_FACTOR_0_75 = 1,
    DGNSSBASE_UDRE_SCALE_FACTOR_0_50 = 2,
    DGNSSBASE_UDRE_SCALE_FACTOR_0_30 = 3,
    DGNSSBASE_UDRE_SCALE_FACTOR_0_20 = 4,
    DGNSSBASE_UDRE_SCALE_FACTOR_0_10 = 5,
    DGNSSBASE_REFERENCE_STATION_TRANSMISSION_NOT_MONITORED = 6,
    DGNSSBASE_REFERENCE_STATION_NOT_WORKING = 7
  }

  public enum HeadingSource {
    HEADINGSOURCE_NONE = 0x0000,
    HEADINGSOURCE_INTERNAL_MAGNETOMETER = 0x0001,
    HEADINGSOURCE_INTERNAL_GPS_VELOCITY_VECTOR = 0x0002,
    HEADINGSOURCE_EXTERNAL_HEADING_UPDATE_CMD = 0x0004,
    HEADINGSOURCE_GNSS_DUAL_ANTENNA = 0x0008
  }

  public enum HeadingUpdateEnableOption {
    ENABLE_NONE = 0x00,
    ENABLE_INTERNAL_MAGNETOMETER = 0x01,
    ENABLE_INTERNAL_GNSS = 0x02,
    ENABLE_EXTERNAL_MESSAGES = 0x03,
    ENABLE_MAGNETOMETER_AND_GNSS = 0x04,
    ENABLE_GNSS_AND_EXTERNAL = 0x05,
    ENABLE_MAGNETOMETER_AND_EXTERNAL = 0x06,
    ENABLE_ALL = 0x07
  }

  public enum EstimationControlOption {
    ENABLE_GYRO_BIAS_ESTIMATION = 0x0001,
    ENABLE_ACCEL_BIAS_ESTIMATION = 0x0002,
    ENABLE_GYRO_SCALE_FACTOR_ESTIMATION = 0x0004,
    ENABLE_ACCEL_SCALE_FACTOR_ESTIMATION = 0X0008,
    ENABLE_GNSS_ANTENNA_OFFSET_ESTIMATION = 0X0010,
    ENABLE_HARD_IRON_AUTO_CALIBRATION = 0X0020,
    ENABLE_SOFT_IRON_AUTO_CALIBRATION = 0x0040
  }

  public enum GeographicSourceOption {
    NONE = 0x01,
    WORLD_MAGNETIC_MODEL = 0x02,
    MANUAL = 0x03
  }

  public enum AdaptiveMeasurementMode {
    ADAPTIVE_MEASUREMENT_DISABLE = 0x00,
    ADAPTIVE_MEASUREMENT_ENABLE_FIXED = 0x01,
    ADAPTIVE_MEASUREMENT_ENABLE_AUTO = 0x02
  }

  public enum AidingMeasurementSource {
    GNSS_POS_VEL_AIDING = 0x0000,
    GNSS_HEADING_AIDING = 0x0001,
    ALTIMETER_AIDING = 0x0002,
    ODOMETER_AIDING = 0x0003,
    MAGNETOMETER_AIDING = 0x0004,
    EXTERNAL_HEADING_AIDING = 0x0005,
    ALL_AIDING_MEASUREMENTS = 0xFFFF
  }

  public enum ConstellationId {
    GPS = 0x00,
    SBAS = 0x01,
    GALILEO = 0x02,
    BEIDOU = 0x03,
    QZSS = 0x05,
    GLONASS = 0x06
  }

  public enum AutoAdaptiveFilteringLevel {
    FILTERING_OFF = 0x00,
    FILTERING_CONSERVATIVE = 0x01,
    FILTERING_MODERATE = 0x02,
    FILTERING_AGGRESIVE = 0x03
  }

  public enum FactoryStreamingOption {
    FACTORY_STREAMING_OVERWRITE = 0x00,
    FACTORY_STREAMING_MERGE = 0x01,
    FACTORY_STREAMING_ADDITIVE = 0x02
  }

  public enum PpsSource {
    PPS_DISABLED = 0x00,
    PPS_RECEIVER_1 = 0x01,
    PPS_RECEIVER_2 = 0x02,
    PPS_GPIO = 0x03,
    PPS_GENERATED = 0x04
  }

  public enum GnssAidingStatus {
    GNSS_AIDING_TIGHT_COUPLING = 0x0001,
    GNSS_AIDING_DIFFERENTIAL = 0x0002,
    GNSS_AIDING_INTEGER_FIX = 0x0004,
    GNSS_AIDING_GPS = 0x0038,
    GNSS_AIDING_GLONASS = 0x00C0,
    GNSS_AIDING_GALILEO = 0x0700,
    GNSS_AIDING_BEIDOU = 0x3800,
    GNSS_AIDING_NO_FIX = 0x4000,
    GNSS_AIDING_CONFIG_ERROR = 0x8000
  }

  public enum AidingMeasurementStatus {
    AIDING_MEASUREMENT_ENABLED = 0x0001,
    AIDING_MEASUREMENT_USED = 0x0002,
    AIDING_MEASUREMENT_WARNING_RESIDUAL_HIGH = 0x0004,
    AIDING_MEASUREMENT_WARNING_SAMPLE_TIME = 0x0008,
    AIDING_MEASUREMENT_CONFIG_ERROR = 0x0010,
    AIDING_MEASUREMENT_MAX_COUNT_EXCEEDED = 0x0020
  }

  public enum RtkCorrectionsStatus {
    RTK_CORRECTION_ANTENNA_POS_RECEIVED = 0x0001,
    RTK_CORRECTION_ANTENNA_DESC_RECEIVED = 0x0002,
    RTK_CORRECTION_GPS_RECEIVED = 0x0004,
    RTK_CORRECTION_GLONASS_RECEIVED = 0x0008,
    RTK_CORRECTION_GALILEO_RECEIVED = 0x0010,
    RTK_CORRECTION_BEIDOU_RECEIVED = 0x0020,
    RTK_CORRECTION_USING_GPS_MSM = 0x0040,
    RTK_CORRECTION_USING_GLONASS_MSM = 0x0080
  }

  public enum GnssSignalQuality {
    SIGNAL_QUALITY_NONE = 0x00,
    SIGNAL_QUALITY_SEARCHING = 0x01,
    SIGNAL_QUALITY_ACQUIRED = 0x02,
    SIGNAL_QUALITY_UNUSABLE = 0x03,
    SIGNAL_QUALITY_TIME_LOCKED = 0x04,
    SIGNAL_QUALITY_FULLY_LOCKED = 0x05
  }

  public enum OverrangeStatusBitmask {
    OVERRANGE_ACCEL_X = 0x0001,
    OVERRANGE_ACCEL_Y = 0x0002,
    OVERRANGE_ACCEL_Z = 0x0004,
    OVERRANGE_GYRO_X = 0x0010,
    OVERRANGE_GYRO_Y = 0x0020,
    OVERRANGE_GYRO_Z = 0x0040,
    OVERRANGE_MAG_X = 0x0100,
    OVERRANGE_MAG_Y = 0x0200,
    OVERRANGE_MAG_Z = 0x0400,
    OVERRANGE_PRESSURE = 0x1000
  }

}

}
