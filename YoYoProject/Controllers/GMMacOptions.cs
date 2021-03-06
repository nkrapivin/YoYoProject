﻿using System;
using YoYoProject.Common;
using YoYoProject.Models;

namespace YoYoProject.Controllers
{
    public sealed class GMMacOptions : GMResource
    {
        private string displayName;
        public string DisplayName
        {
            get { return GetProperty(displayName); }
            set { SetProperty(value, ref displayName); }
        }
        
        private string appId;
        public string AppId
        {
            get { return GetProperty(appId); }
            set { SetProperty(value, ref appId); }
        }
        
        private BuildVersion version;
        public BuildVersion Version
        {
            get { return GetProperty(version); }
            set { SetProperty(value, ref version); }
        }
        
        private string outputDirectory;
        public string OutputDirectory
        {
            get { return GetProperty(outputDirectory); }
            set { SetProperty(value, ref outputDirectory); }
        }
        
        private string teamId;
        public string TeamId
        {
            get { return GetProperty(teamId); }
            set { SetProperty(value, ref teamId); }
        }
        
        private string signingIdentity;
        public string SigningIdentity
        {
            get { return GetProperty(signingIdentity); }
            set { SetProperty(value, ref signingIdentity); }
        }
        
        private string copyright;
        public string Copyright
        {
            get { return GetProperty(copyright); }
            set { SetProperty(value, ref copyright); }
        }
        
        private string splashPng;
        public string SplashPng
        {
            get { return GetProperty(splashPng); }
            set { SetProperty(value, ref splashPng); }
        }
        
        private string iconPng;
        public string IconPng
        {
            get { return GetProperty(iconPng); }
            set { SetProperty(value, ref iconPng); }
        }
        
        private bool menuDock;
        public bool MenuDock
        {
            get { return GetProperty(menuDock); }
            set { SetProperty(value, ref menuDock); }
        }
        
        private bool displayCursor;
        public bool DisplayCursor
        {
            get { return GetProperty(displayCursor); }
            set { SetProperty(value, ref displayCursor); }
        }
        
        private bool startFullscreen;
        public bool StartFullscreen
        {
            get { return GetProperty(startFullscreen); }
            set { SetProperty(value, ref startFullscreen); }
        }
        
        private bool allowFullscreenSwitching;
        public bool AllowFullscreenSwitching
        {
            get { return GetProperty(allowFullscreenSwitching); }
            set { SetProperty(value, ref allowFullscreenSwitching); }
        }

        private bool interpolatePixels;
        public bool InterpolatePixels
        {
            get { return GetProperty(interpolatePixels); }
            set { SetProperty(value, ref interpolatePixels); }
        }
        
        private bool vsync;
        public bool Vsync
        {
            get { return GetProperty(vsync); }
            set { SetProperty(value, ref vsync); }
        }
        
        private bool resizeWindow;
        public bool ResizeWindow
        {
            get { return GetProperty(resizeWindow); }
            set { SetProperty(value, ref resizeWindow); }
        }
        
        private Scale scaleMode;
        public Scale ScaleMode
        {
            get { return GetProperty(scaleMode); }
            set { SetProperty(value, ref scaleMode); }
        }
        
        private TexturePageSize texturePage;
        public TexturePageSize TexturePage
        {
            get { return GetProperty(texturePage); }
            set { SetProperty(value, ref texturePage); }
        }
        
        private bool appStore;
        public bool AppStore
        {
            get { return GetProperty(appStore); }
            set { SetProperty(value, ref appStore); }
        }
        
        private bool allowIncomingNetwork;
        public bool AllowIncomingNetwork
        {
            get { return GetProperty(allowIncomingNetwork); }
            set { SetProperty(value, ref allowIncomingNetwork); }
        }
        
        private bool allowOutgoingNetwork;
        public bool AllowOutgoingNetwork
        {
            get { return GetProperty(allowOutgoingNetwork); }
            set { SetProperty(value, ref allowOutgoingNetwork); }
        }
        
        private string appCategory;
        public string AppCategory
        {
            get { return GetProperty(appCategory); }
            set { SetProperty(value, ref appCategory); }
        }
        
        private bool enableSteam;
        public bool EnableSteam
        {
            get { return GetProperty(enableSteam); }
            set { SetProperty(value, ref enableSteam); }
        }

        private bool disableSandbox;
        public bool DisableSandbox
        {
            get { return GetProperty(disableSandbox); }
            set { SetProperty(value, ref disableSandbox); }
        }
        
        internal override string ResourcePath => @"options\mac\options_mac.yy";

        internal override void Create(string name)
        {
            DisplayName = "Made in GameMaker Studio 2";
            AppId = "com.company.game";
            Version = new BuildVersion(1, 0, 0, 0);
            OutputDirectory = @"~/GameMakerStudio2/Mac";
            TeamId = "";
            SigningIdentity = "Developer ID Application:";
            Copyright = $"(c) {DateTime.UtcNow.Year} CompanyName";
            SplashPng = @"${base_options_dir}/mac/splash/splash.png"; // TODO Copy in default
            IconPng = @"${base_options_dir}/mac/icons/1024.png"; // TODO Copy in default
            MenuDock = false;
            DisplayCursor = true;
            StartFullscreen = false;
            AllowFullscreenSwitching = false;
            InterpolatePixels = false;
            Vsync = false;
            ResizeWindow = false;
            ScaleMode = Scale.KeepAspectRatio;
            TexturePage = new TexturePageSize(2048, 2048);
            AppStore = false;
            AllowIncomingNetwork = false;
            AllowOutgoingNetwork = false;
            AppCategory = "";
            EnableSteam = false;
            DisableSandbox = false;
        }
        
        internal override ModelBase Serialize()
        {
            return new GMMacOptionsModel
            {
                id = Id,
                name = "macOS",
                option_mac_display_name = DisplayName,
                option_mac_app_id = AppId,
                option_mac_version = Version,
                option_mac_output_dir = OutputDirectory,
                option_mac_team_id = TeamId,
                option_mac_signing_identity = SigningIdentity,
                option_mac_copyright = Copyright,
                option_mac_splash_png = SplashPng,
                option_mac_icon_png = IconPng,
                option_mac_menu_dock = MenuDock,
                option_mac_display_cursor = DisplayCursor,
                option_mac_start_fullscreen = StartFullscreen,
                option_mac_allow_fullscreen = AllowFullscreenSwitching,
                option_mac_interpolate_pixels = InterpolatePixels,
                option_mac_vsync = Vsync,
                option_mac_resize_window = ResizeWindow,
                option_mac_scale = ScaleMode,
                option_mac_texture_page = TexturePage.ToString(),
                option_mac_build_app_store = AppStore,
                option_mac_allow_incoming_network = AllowIncomingNetwork,
                option_mac_allow_outgoing_network = AllowOutgoingNetwork,
                option_mac_app_category = AppCategory,
                option_mac_enable_steam = EnableSteam,
                option_mac_disable_sandbox = DisableSandbox
            };
        }

        internal override void Deserialize(ModelBase model)
        {
            var macOptionsModel = (GMMacOptionsModel)model;

            Id = macOptionsModel.id;
            Name = macOptionsModel.name;
            DisplayName = macOptionsModel.option_mac_display_name;
            AppId = macOptionsModel.option_mac_app_id;
            Version = macOptionsModel.option_mac_version;
            OutputDirectory = macOptionsModel.option_mac_output_dir;
            TeamId = macOptionsModel.option_mac_team_id;
            SigningIdentity = macOptionsModel.option_mac_signing_identity;
            Copyright = macOptionsModel.option_mac_copyright;
            SplashPng = macOptionsModel.option_mac_splash_png;
            IconPng = macOptionsModel.option_mac_icon_png;
            DisplayCursor = macOptionsModel.option_mac_display_cursor;
            StartFullscreen = macOptionsModel.option_mac_start_fullscreen;
            AllowFullscreenSwitching = macOptionsModel.option_mac_allow_fullscreen;
            InterpolatePixels = macOptionsModel.option_mac_interpolate_pixels;
            Vsync = macOptionsModel.option_mac_vsync;
            ResizeWindow = macOptionsModel.option_mac_resize_window;
            ScaleMode = macOptionsModel.option_mac_scale;
            TexturePage = new TexturePageSize(macOptionsModel.option_mac_texture_page);
            AppStore = macOptionsModel.option_mac_build_app_store;
            AllowIncomingNetwork = macOptionsModel.option_mac_allow_incoming_network;
            AllowOutgoingNetwork = macOptionsModel.option_mac_allow_outgoing_network;
            AppCategory = macOptionsModel.option_mac_app_category;
            EnableSteam = macOptionsModel.option_mac_enable_steam;
            DisableSandbox = macOptionsModel.option_mac_disable_sandbox;
        }
    }
}