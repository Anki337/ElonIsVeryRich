﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ElonIsVeryRich.DAL
{
    // Här börjar Rockets
    public class CompositeFairing
    {
        [JsonPropertyName("height")]
        public Height? Height { get; set; }

        [JsonPropertyName("diameter")]
        public Diameter? Diameter { get; set; }
    }

    public class Diameter
    {
        [JsonPropertyName("meters")]
        public double? Meters { get; set; }

        [JsonPropertyName("feet")]
        public double? Feet { get; set; }
    }

    public class Engines
    {
        [JsonPropertyName("number")]
        public int? Number { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("layout")]
        public string? Layout { get; set; }

        [JsonPropertyName("engine_loss_max")]
        public int? EngineLossMax { get; set; }

        [JsonPropertyName("propellant_1")]
        public string? Propellant1 { get; set; }

        [JsonPropertyName("propellant_2")]
        public string? Propellant2 { get; set; }

        [JsonPropertyName("thrust_sea_level")]
        public ThrustSeaLevel? ThrustSeaLevel { get; set; }

        [JsonPropertyName("thrust_vacuum")]
        public ThrustVacuum? ThrustVacuum { get; set; }

        [JsonPropertyName("thrust_to_weight")]
        public double? ThrustToWeight { get; set; }
    }

    public class FirstStage
    {
        [JsonPropertyName("reusable")]
        public bool? Reusable { get; set; }

        [JsonPropertyName("engines")]
        public int? Engines { get; set; }

        [JsonPropertyName("fuel_amount_tons")]
        public double? FuelAmountTons { get; set; }

        [JsonPropertyName("burn_time_sec")]
        public int? BurnTimeSec { get; set; }

        [JsonPropertyName("thrust_sea_level")]
        public ThrustSeaLevel? ThrustSeaLevel { get; set; }

        [JsonPropertyName("thrust_vacuum")]
        public ThrustVacuum? ThrustVacuum { get; set; }

        [JsonPropertyName("cores")]
        public int? Cores { get; set; }
    }

    public class Height
    {
        [JsonPropertyName("meters")]
        public double? Meters { get; set; }

        [JsonPropertyName("feet")]
        public double? Feet { get; set; }
    }

    public class LandingLegs
    {
        [JsonPropertyName("number")]
        public int? Number { get; set; }

        [JsonPropertyName("material")]
        public string? Material { get; set; }
    }

    public class Mass
    {
        [JsonPropertyName("kg")]
        public int? Kg { get; set; }

        [JsonPropertyName("lb")]
        public int? Lb { get; set; }
    }

    public class Payloads
    {
        [JsonPropertyName("option_1")]
        public string? Option1 { get; set; }

        [JsonPropertyName("composite_fairing")]
        public CompositeFairing? CompositeFairing { get; set; }

        [JsonPropertyName("option_2")]
        public string? Option2 { get; set; }
    }

    public class PayloadWeight
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("kg")]
        public int? Kg { get; set; }

        [JsonPropertyName("lb")]
        public int? Lb { get; set; }
    }

    public class RootRocketModel
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("stages")]
        public int? Stages { get; set; }

        [JsonPropertyName("boosters")]
        public int? Boosters { get; set; }

        [JsonPropertyName("cost_per_launch")]
        public int? cost_per_launch { get; set; } // Det är denna som är intressant för oss. "cost_per_launch".

        [JsonPropertyName("success_rate_pct")]
        public int? SuccessRatePct { get; set; }

        [JsonPropertyName("first_flight")]
        public string? FirstFlight { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("company")]
        public string? Company { get; set; }

        [JsonPropertyName("height")]
        public Height? Height { get; set; }

        [JsonPropertyName("diameter")]
        public Diameter? Diameter { get; set; }

        [JsonPropertyName("mass")]
        public Mass? Mass { get; set; }

        [JsonPropertyName("payload_weights")]
        public List<PayloadWeight>? PayloadWeights { get; set; }

        [JsonPropertyName("first_stage")]
        public FirstStage? FirstStage { get; set; }

        [JsonPropertyName("second_stage")]
        public SecondStage? SecondStage { get; set; }

        [JsonPropertyName("engines")]
        public Engines? Engines { get; set; }

        [JsonPropertyName("landing_legs")]
        public LandingLegs? LandingLegs { get; set; }

        [JsonPropertyName("wikipedia")]
        public string? Wikipedia { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("rocket_id")]
        public string? RocketId { get; set; }

        [JsonPropertyName("rocket_name")]
        public string? rocket_name { get; set; }

        [JsonPropertyName("rocket_type")]
        public string? RocketType { get; set; }
    }

    public class SecondStage
    {
        [JsonPropertyName("engines")]
        public int? Engines { get; set; }

        [JsonPropertyName("fuel_amount_tons")]
        public double? FuelAmountTons { get; set; }

        [JsonPropertyName("burn_time_sec")]
        public int? BurnTimeSec { get; set; }

        [JsonPropertyName("thrust")]
        public Thrust? Thrust { get; set; }

        [JsonPropertyName("payloads")]
        public Payloads? Payloads { get; set; }
    }

    public class Thrust
    {
        [JsonPropertyName("kN")]
        public int? KN { get; set; }

        [JsonPropertyName("lbf")]
        public int? Lbf { get; set; }
    }

    public class ThrustSeaLevel
    {
        [JsonPropertyName("kN")]
        public int? KN { get; set; }

        [JsonPropertyName("lbf")]
        public int? Lbf { get; set; }
    }

    public class ThrustVacuum
    {
        [JsonPropertyName("kN")]
        public int? KN { get; set; }

        [JsonPropertyName("lbf")]
        public int? Lbf { get; set; }
    }

    // Här börjar Launches

    public class CoreModel
    {
        [JsonPropertyName("core_serial")]
        public string? CoreSerial { get; set; }

        [JsonPropertyName("flight")]
        public int? Flight { get; set; }

        [JsonPropertyName("block")]
        public int? Block { get; set; }

        [JsonPropertyName("gridfins")]
        public bool? Gridfins { get; set; }

        [JsonPropertyName("legs")]
        public bool? Legs { get; set; }

        [JsonPropertyName("reused")]
        public bool? Reused { get; set; }

        [JsonPropertyName("land_success")]
        public bool? LandSuccess { get; set; }

        [JsonPropertyName("landing_intent")]
        public bool? LandingIntent { get; set; }

        [JsonPropertyName("landing_type")]
        public string? LandingType { get; set; }

        [JsonPropertyName("landing_vehicle")]
        public string? LandingVehicle { get; set; }
    }

    public class FairingsModel
    {
        [JsonPropertyName("reused")]
        public bool? Reused { get; set; }

        [JsonPropertyName("recovery_attempt")]
        public bool? RecoveryAttempt { get; set; }

        [JsonPropertyName("recovered")]
        public bool? Recovered { get; set; }

        [JsonPropertyName("ship")]
        public string? Ship { get; set; }
    }

    public class FirstStageModel
    {
        [JsonPropertyName("cores")]
        public List<CoreModel>? Cores { get; set; }
    }

    public class LaunchFailureDetailsModel
    {
        [JsonPropertyName("time")]
        public int? Time { get; set; }

        [JsonPropertyName("altitude")]
        public int? Altitude { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }

    public class LaunchSiteModel
    {
        [JsonPropertyName("site_id")]
        public string? SiteId { get; set; }

        [JsonPropertyName("site_name")]
        public string? site_name { get; set; }

        [JsonPropertyName("site_name_long")]
        public string? SiteNameLong { get; set; }
    }

    public class LinksModel
    {
        [JsonPropertyName("mission_patch")]
        public string? MissionPatch { get; set; }

        [JsonPropertyName("mission_patch_small")]
        public string? MissionPatchSmall { get; set; }

        [JsonPropertyName("reddit_campaign")]
        public string? RedditCampaign { get; set; }

        [JsonPropertyName("reddit_launch")]
        public string? RedditLaunch { get; set; }

        [JsonPropertyName("reddit_recovery")]
        public string? RedditRecovery { get; set; }

        [JsonPropertyName("reddit_media")]
        public string? RedditMedia { get; set; }

        [JsonPropertyName("presskit")]
        public string? Presskit { get; set; }

        [JsonPropertyName("article_link")]
        public string? ArticleLink { get; set; }

        [JsonPropertyName("wikipedia")]
        public string? Wikipedia { get; set; }

        [JsonPropertyName("video_link")]
        public string? video_link { get; set; }

        [JsonPropertyName("youtube_id")]
        public string? YoutubeId { get; set; }

        [JsonPropertyName("flickr_images")]
        public List<string>? FlickrImages { get; set; }
    }

    public class OrbitParamsModel
    {
        [JsonPropertyName("reference_system")]
        public string? ReferenceSystem { get; set; }

        [JsonPropertyName("regime")]
        public string? Regime { get; set; }

        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        [JsonPropertyName("semi_major_axis_km")]
        public double? SemiMajorAxisKm { get; set; }

        [JsonPropertyName("eccentricity")]
        public double? Eccentricity { get; set; }

        [JsonPropertyName("periapsis_km")]
        public double? PeriapsisKm { get; set; }

        [JsonPropertyName("apoapsis_km")]
        public double? ApoapsisKm { get; set; }

        [JsonPropertyName("inclination_deg")]
        public double? InclinationDeg { get; set; }

        [JsonPropertyName("period_min")]
        public double? PeriodMin { get; set; }

        [JsonPropertyName("lifespan_years")]
        public double? LifespanYears { get; set; }

        [JsonPropertyName("epoch")]
        public DateTime? Epoch { get; set; }

        [JsonPropertyName("mean_motion")]
        public double? MeanMotion { get; set; }

        [JsonPropertyName("raan")]
        public double? Raan { get; set; }

        [JsonPropertyName("arg_of_pericenter")]
        public double? ArgOfPericenter { get; set; }

        [JsonPropertyName("mean_anomaly")]
        public double? MeanAnomaly { get; set; }
    }

    public class PayloadModel
    {
        [JsonPropertyName("payload_id")]
        public string? PayloadId { get; set; }

        [JsonPropertyName("norad_id")]
        public List<int>? NoradId { get; set; }

        [JsonPropertyName("reused")]
        public bool? Reused { get; set; }

        [JsonPropertyName("customers")]
        public List<string>? Customers { get; set; }

        [JsonPropertyName("nationality")]
        public string? Nationality { get; set; }

        [JsonPropertyName("manufacturer")]
        public string? Manufacturer { get; set; }

        [JsonPropertyName("payload_type")]
        public string? PayloadType { get; set; }

        [JsonPropertyName("payload_mass_kg")]
        public double? PayloadMassKg { get; set; }

        [JsonPropertyName("payload_mass_lbs")]
        public double? PayloadMassLbs { get; set; }

        [JsonPropertyName("orbit")]
        public string? Orbit { get; set; }

        [JsonPropertyName("orbit_params")]
        public OrbitParamsModel? OrbitParams { get; set; }

        [JsonPropertyName("cap_serial")]
        public string? CapSerial { get; set; }

        [JsonPropertyName("mass_returned_kg")]
        public double? MassReturnedKg { get; set; }

        [JsonPropertyName("mass_returned_lbs")]
        public double? MassReturnedLbs { get; set; }

        [JsonPropertyName("flight_time_sec")]
        public int? FlightTimeSec { get; set; }

        [JsonPropertyName("cargo_manifest")]
        public string? CargoManifest { get; set; }
    }

    public class RocketModel
    {
        [JsonPropertyName("rocket_id")]
        public string? RocketId { get; set; }

        [JsonPropertyName("rocket_name")]
        public string? rocket_name { get; set; }

        [JsonPropertyName("rocket_type")]
        public string? RocketType { get; set; }

        [JsonPropertyName("first_stage")]
        public FirstStageModel? FirstStage { get; set; }

        [JsonPropertyName("second_stage")]
        public SecondStageModel? SecondStage { get; set; }

        [JsonPropertyName("fairings")]
        public FairingsModel? Fairings { get; set; }
    }

    public class RootModel
    {
        [JsonPropertyName("flight_number")] // 
        public int? flight_number { get; set; }

        [JsonPropertyName("mission_name")]
        public string? mission_name { get; set; }

        [JsonPropertyName("mission_id")]
        public List<string>? MissionId { get; set; }

        [JsonPropertyName("upcoming")]
        public bool? Upcoming { get; set; }

        [JsonPropertyName("launch_year")]
        public string? launch_year { get; set; }

        [JsonPropertyName("launch_date_unix")]
        public int? LaunchDateUnix { get; set; }

        [JsonPropertyName("launch_date_utc")]
        public DateTime? launch_date_utc { get; set; }

        [JsonPropertyName("launch_date_local")]
        public DateTime? LaunchDateLocal { get; set; }

        [JsonPropertyName("is_tentative")]
        public bool? IsTentative { get; set; }

        [JsonPropertyName("tentative_max_precision")]
        public string? TentativeMaxPrecision { get; set; }

        [JsonPropertyName("tbd")]
        public bool? Tbd { get; set; }

        [JsonPropertyName("launch_window")]
        public int? LaunchWindow { get; set; }

        [JsonPropertyName("rocket")]
        public RocketModel? Rocket { get; set; }

        [JsonPropertyName("ships")]
        public List<string>? Ships { get; set; }

        [JsonPropertyName("telemetry")]
        public TelemetryModel? Telemetry { get; set; }

        [JsonPropertyName("launch_site")]
        public LaunchSiteModel? launch_site { get; set; }

        [JsonPropertyName("launch_success")]
        public bool? launch_success { get; set; }

        [JsonPropertyName("launch_failure_details")]
        public LaunchFailureDetailsModel? LaunchFailureDetails { get; set; }

        [JsonPropertyName("links")]
        public LinksModel? links { get; set; }

        [JsonPropertyName("details")]
        public string? Details { get; set; }

        [JsonPropertyName("static_fire_date_utc")]
        public DateTime? StaticFireDateUtc { get; set; }

        [JsonPropertyName("static_fire_date_unix")]
        public int? StaticFireDateUnix { get; set; }

        [JsonPropertyName("timeline")]
        public TimelineModel? Timeline { get; set; }
    }

    public class SecondStageModel
    {
        [JsonPropertyName("block")]
        public int? Block { get; set; }

        [JsonPropertyName("payloads")]
        public List<PayloadModel>? Payloads { get; set; }
    }

    public class TelemetryModel
    {
        [JsonPropertyName("flight_club")]
        public string? FlightClub { get; set; }
    }

    public class TimelineModel
    {
        [JsonPropertyName("webcast_liftoff")]
        public int? WebcastLiftoff { get; set; }

        [JsonPropertyName("go_for_prop_loading")]
        public int? GoForPropLoading { get; set; }

        [JsonPropertyName("rp1_loading")]
        public int? Rp1Loading { get; set; }

        [JsonPropertyName("stage1_lox_loading")]
        public int? Stage1LoxLoading { get; set; }

        [JsonPropertyName("stage2_lox_loading")]
        public int? Stage2LoxLoading { get; set; }

        [JsonPropertyName("engine_chill")]
        public int? EngineChill { get; set; }

        [JsonPropertyName("prelaunch_checks")]
        public int? PrelaunchChecks { get; set; }

        [JsonPropertyName("propellant_pressurization")]
        public int? PropellantPressurization { get; set; }

        [JsonPropertyName("go_for_launch")]
        public int? GoForLaunch { get; set; }

        [JsonPropertyName("ignition")]
        public int? Ignition { get; set; }

        [JsonPropertyName("liftoff")]
        public int? Liftoff { get; set; }

        [JsonPropertyName("maxq")]
        public int? Maxq { get; set; }

        [JsonPropertyName("meco")]
        public int? Meco { get; set; }

        [JsonPropertyName("stage_sep")]
        public int? StageSep { get; set; }

        [JsonPropertyName("second_stage_ignition")]
        public int? SecondStageIgnition { get; set; }

        [JsonPropertyName("seco-1")]
        public int? Seco1 { get; set; }

        [JsonPropertyName("dragon_separation")]
        public int? DragonSeparation { get; set; }

        [JsonPropertyName("dragon_solar_deploy")]
        public int? DragonSolarDeploy { get; set; }

        [JsonPropertyName("dragon_bay_door_deploy")]
        public int? DragonBayDoorDeploy { get; set; }

        [JsonPropertyName("fairing_deploy")]
        public int? FairingDeploy { get; set; }

        [JsonPropertyName("payload_deploy")]
        public int? PayloadDeploy { get; set; }

        [JsonPropertyName("second_stage_restart")]
        public int? SecondStageRestart { get; set; }

        [JsonPropertyName("seco-2")]
        public int? Seco2 { get; set; }

        [JsonPropertyName("webcast_launch")]
        public int? WebcastLaunch { get; set; }

        [JsonPropertyName("payload_deploy_1")]
        public int? PayloadDeploy1 { get; set; }

        [JsonPropertyName("payload_deploy_2")]
        public int? PayloadDeploy2 { get; set; }

        [JsonPropertyName("first_stage_boostback_burn")]
        public int? FirstStageBoostbackBurn { get; set; }

        [JsonPropertyName("first_stage_entry_burn")]
        public int? FirstStageEntryBurn { get; set; }

        [JsonPropertyName("first_stage_landing")]
        public int? FirstStageLanding { get; set; }

        [JsonPropertyName("beco")]
        public int? Beco { get; set; }

        [JsonPropertyName("side_core_sep")]
        public int? SideCoreSep { get; set; }

        [JsonPropertyName("side_core_boostback")]
        public int? SideCoreBoostback { get; set; }

        [JsonPropertyName("center_stage_sep")]
        public int? CenterStageSep { get; set; }

        [JsonPropertyName("center_core_boostback")]
        public int? CenterCoreBoostback { get; set; }

        [JsonPropertyName("side_core_entry_burn")]
        public int? SideCoreEntryBurn { get; set; }

        [JsonPropertyName("center_core_entry_burn")]
        public int? CenterCoreEntryBurn { get; set; }

        [JsonPropertyName("side_core_landing")]
        public int? SideCoreLanding { get; set; }

        [JsonPropertyName("center_core_landing")]
        public int? CenterCoreLanding { get; set; }
    }
}





