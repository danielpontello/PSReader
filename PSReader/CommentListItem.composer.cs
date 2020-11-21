// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSReader
{
    partial class CommentListItem
    {
        public Label CommentBy;
        public Label CommentTime;
        public Label CommentContent;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            CommentBy = new Label();
            CommentBy.Name = "CommentBy";
            CommentTime = new Label();
            CommentTime.Name = "CommentTime";
            CommentContent = new Label();
            CommentContent.Name = "CommentContent";

            // CommentListItem
            this.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 0f / 255f);
            this.AddChildLast(CommentBy);
            this.AddChildLast(CommentTime);
            this.AddChildLast(CommentContent);

            // CommentBy
            CommentBy.TextColor = new UIColor(95f / 255f, 95f / 255f, 95f / 255f, 255f / 255f);
            CommentBy.Font = new UIFont(FontAlias.System, 20, FontStyle.Regular);
            CommentBy.LineBreak = LineBreak.Character;

            // CommentTime
            CommentTime.TextColor = new UIColor(95f / 255f, 95f / 255f, 95f / 255f, 255f / 255f);
            CommentTime.Font = new UIFont(FontAlias.System, 20, FontStyle.Regular);
            CommentTime.LineBreak = LineBreak.Character;
            CommentTime.HorizontalAlignment = HorizontalAlignment.Right;

            // CommentContent
            CommentContent.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            CommentContent.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            CommentContent.LineBreak = LineBreak.Character;
            CommentContent.VerticalAlignment = VerticalAlignment.Top;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(58, 960);
                    this.Anchors = Anchors.None;

                    CommentBy.SetPosition(0, 0);
                    CommentBy.SetSize(214, 36);
                    CommentBy.Anchors = Anchors.None;
                    CommentBy.Visible = true;

                    CommentTime.SetPosition(480, 0);
                    CommentTime.SetSize(214, 36);
                    CommentTime.Anchors = Anchors.None;
                    CommentTime.Visible = true;

                    CommentContent.SetPosition(0, 36);
                    CommentContent.SetSize(214, 36);
                    CommentContent.Anchors = Anchors.None;
                    CommentContent.Visible = true;

                    break;

                default:
                    this.SetSize(960, 120);
                    this.Anchors = Anchors.None;

                    CommentBy.SetPosition(0, 0);
                    CommentBy.SetSize(480, 36);
                    CommentBy.Anchors = Anchors.None;
                    CommentBy.Visible = true;

                    CommentTime.SetPosition(480, 0);
                    CommentTime.SetSize(455, 36);
                    CommentTime.Anchors = Anchors.None;
                    CommentTime.Visible = true;

                    CommentContent.SetPosition(0, 36);
                    CommentContent.SetSize(935, 84);
                    CommentContent.Anchors = Anchors.None;
                    CommentContent.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            CommentBy.Text = "CommentBy";

            CommentTime.Text = "CommentTime";

            CommentContent.Text = "label";
        }

        public void InitializeDefaultEffect()
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        public void StartDefaultEffect()
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        public static ListPanelItem Creator()
        {
            return new CommentListItem();
        }

    }
}
