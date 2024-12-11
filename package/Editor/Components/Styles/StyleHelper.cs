using UnityEditor;
using UnityEngine.UIElements;

namespace Rive
{
    /// <summary>
    /// Helper class for styling Rive components.
    /// </summary>
    internal class StyleHelper
    {
        // USS Class Names
        /// <summary>
        /// The block class name for the Rive inspector.
        /// </summary>
        public const string CLASS_BLOCK = "rive-inspector";

        /// <summary>
        /// The element class name for sections within the Rive inspector.
        /// </summary>
        public const string CLASS_SECTION = "rive-inspector__section";

        /// <summary>
        /// The element class name for section labels within the Rive inspector.
        /// </summary>
        public const string CLASS_SECTION_LABEL = "rive-inspector__section-label";

        /// <summary>
        /// The element class name for fields within the Rive inspector.
        /// </summary>
        public const string CLASS_FIELD = "rive-inspector__field";


        private static StyleSheet s_StyleSheet;

        public static StyleSheet StyleSheet
        {
            get
            {
                if (s_StyleSheet == null)
                {
                    string ussPath = "Packages/app.rive.rive-unity/Editor/Components/Styles/RiveInspectorStyleSheet.uss";
                    s_StyleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>(ussPath);
                }
                return s_StyleSheet;
            }
        }
    }
}
