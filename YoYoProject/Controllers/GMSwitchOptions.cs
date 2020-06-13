using YoYoProject.Common;
using YoYoProject.Models;

namespace YoYoProject.Controllers
{
    public sealed class GMSwitchOptions : GMResource
    {
        private bool checkNSPPublishErrors;
        public bool CheckNSPPublishErrors
        {
            get { return GetProperty(checkNSPPublishErrors); }
            set { SetProperty(value, ref checkNSPPublishErrors); }
        }

        private bool enableFileAccessChecking;
        public bool EnableFileAccessChecking
        {
            get { return GetProperty(enableFileAccessChecking); }
            set { SetProperty(value, ref enableFileAccessChecking); }
        }

        private bool enableNEXLibraries;
        public bool EnableNEXLibraries
        {
            get { return GetProperty(enableNEXLibraries); }
            set { SetProperty(value, ref enableNEXLibraries); }
        }

        private bool interpolatePixels;
        public bool InterpolatePixels
        {
            get { return GetProperty(interpolatePixels); }
            set { SetProperty(value, ref interpolatePixels); }
        }

        private Scale scaleMode;
        public Scale ScaleMode
        {
            get { return GetProperty(scaleMode); }
            set { SetProperty(value, ref scaleMode); }
        }

        private string projectNmeta;
        public string ProjectNmeta
        {
            get { return GetProperty(projectNmeta); }
            set { SetProperty(value, ref projectNmeta); }
        }

        private TexturePageSize texturePage;
        public TexturePageSize TexturePage
        {
            get { return GetProperty(texturePage); }
            set { SetProperty(value, ref texturePage); }
        }


        internal override string ResourcePath => @"options\switch\options_switch.yy";

        internal override void Create(string name)
        {
            CheckNSPPublishErrors = true;
            EnableFileAccessChecking = true;
            EnableNEXLibraries = false;
            InterpolatePixels = true;
            ScaleMode = Scale.KeepAspectRatio;
            TexturePage = new TexturePageSize(2048, 2048);
            ProjectNmeta = @"${options_dir}/switch/application.nmeta"; // I don't bundle the default nmeta as it's 100% under NDA.
        }

        internal override ModelBase Serialize()
        {
            return new GMSwitchOptionsModel
            {
                id = Id,
                name = "Switch",
                option_switch_check_nsp_publish_errors = CheckNSPPublishErrors,
                option_switch_enable_fileaccess_checking = EnableFileAccessChecking,
                option_switch_enable_nex_libraries = EnableNEXLibraries,
                option_switch_interpolate_pixels = InterpolatePixels,
                option_switch_project_nmeta = ProjectNmeta,
                option_switch_scale = ScaleMode,
                option_switch_texture_page = TexturePage.ToString()
            };
        }

        internal override void Deserialize(ModelBase model)
        {
            var switchOptionsModel = (GMSwitchOptionsModel)model;

            Id = switchOptionsModel.id;
            Name = switchOptionsModel.name;
            CheckNSPPublishErrors = switchOptionsModel.option_switch_check_nsp_publish_errors;
            EnableFileAccessChecking = switchOptionsModel.option_switch_enable_fileaccess_checking;
            EnableNEXLibraries = switchOptionsModel.option_switch_enable_nex_libraries;
            InterpolatePixels = switchOptionsModel.option_switch_interpolate_pixels;
            ProjectNmeta = switchOptionsModel.option_switch_project_nmeta;
            ScaleMode = switchOptionsModel.option_switch_scale;
            TexturePage = new TexturePageSize(switchOptionsModel.option_switch_texture_page);
        }
    }
}
