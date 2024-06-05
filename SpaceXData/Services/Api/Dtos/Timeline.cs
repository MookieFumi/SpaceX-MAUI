using System.Text.Json.Serialization;

namespace SpaceXData.Services.Dtos
{
    public class Timeline
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

        [JsonPropertyName("first_stage_landing_burn")]
        public int? FirstStageLandingBurn { get; set; }

        [JsonPropertyName("stage1_rp1_loading")]
        public int? Stage1Rp1Loading { get; set; }

        [JsonPropertyName("stage2_rp1_loading")]
        public int? Stage2Rp1Loading { get; set; }

        [JsonPropertyName("seco-3")]
        public int? Seco3 { get; set; }

        [JsonPropertyName("seco-4")]
        public int? Seco4 { get; set; }
    }


}

