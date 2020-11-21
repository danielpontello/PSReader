// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSReader
{
    partial class StoryListItem
    {
        public Label ListItemTitle;
        public Label ListItemAuthor;
        public Label ListItemTime;
        public Label ListItemIndex;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            ListItemTitle = new Label();
            ListItemTitle.Name = "ListItemTitle";
            ListItemAuthor = new Label();
            ListItemAuthor.Name = "ListItemAuthor";
            ListItemTime = new Label();
            ListItemTime.Name = "ListItemTime";
            ListItemIndex = new Label();
            ListItemIndex.Name = "ListItemIndex";

            // StoryListItem
            this.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 0f / 255f);
            this.AddChildLast(ListItemTitle);
            this.AddChildLast(ListItemAuthor);
            this.AddChildLast(ListItemTime);
            this.AddChildLast(ListItemIndex);

            // ListItemTitle
            ListItemTitle.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            ListItemTitle.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            ListItemTitle.LineBreak = LineBreak.Character;

            // ListItemAuthor
            ListItemAuthor.TextColor = new UIColor(95f / 255f, 95f / 255f, 95f / 255f, 255f / 255f);
            ListItemAuthor.Font = new UIFont(FontAlias.System, 20, FontStyle.Regular);
            ListItemAuthor.LineBreak = LineBreak.Character;

            // ListItemTime
            ListItemTime.TextColor = new UIColor(95f / 255f, 95f / 255f, 95f / 255f, 255f / 255f);
            ListItemTime.Font = new UIFont(FontAlias.System, 20, FontStyle.Regular);
            ListItemTime.LineBreak = LineBreak.Character;
            ListItemTime.HorizontalAlignment = HorizontalAlignment.Right;

            // ListItemIndex
            ListItemIndex.TextColor = new UIColor(95f / 255f, 95f / 255f, 95f / 255f, 255f / 255f);
            ListItemIndex.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            ListItemIndex.LineBreak = LineBreak.Character;
            ListItemIndex.HorizontalAlignment = HorizontalAlignment.Center;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(544, 960);
                    this.Anchors = Anchors.None;

                    ListItemTitle.SetPosition(0, 0);
                    ListItemTitle.SetSize(214, 36);
                    ListItemTitle.Anchors = Anchors.None;
                    ListItemTitle.Visible = true;

                    ListItemAuthor.SetPosition(0, 36);
                    ListItemAuthor.SetSize(214, 36);
                    ListItemAuthor.Anchors = Anchors.None;
                    ListItemAuthor.Visible = true;

                    ListItemTime.SetPosition(746, 36);
                    ListItemTime.SetSize(214, 36);
                    ListItemTime.Anchors = Anchors.None;
                    ListItemTime.Visible = true;

                    ListItemIndex.SetPosition(0, 0);
                    ListItemIndex.SetSize(214, 36);
                    ListItemIndex.Anchors = Anchors.None;
                    ListItemIndex.Visible = true;

                    break;

                default:
                    this.SetSize(960, 58);
                    this.Anchors = Anchors.None;

                    ListItemTitle.SetPosition(71, 0);
                    ListItemTitle.SetSize(863, 36);
                    ListItemTitle.Anchors = Anchors.None;
                    ListItemTitle.Visible = true;

                    ListItemAuthor.SetPosition(71, 36);
                    ListItemAuthor.SetSize(472, 22);
                    ListItemAuthor.Anchors = Anchors.None;
                    ListItemAuthor.Visible = true;

                    ListItemTime.SetPosition(543, 36);
                    ListItemTime.SetSize(391, 22);
                    ListItemTime.Anchors = Anchors.None;
                    ListItemTime.Visible = true;

                    ListItemIndex.SetPosition(0, 0);
                    ListItemIndex.SetSize(71, 58);
                    ListItemIndex.Anchors = Anchors.None;
                    ListItemIndex.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            ListItemTitle.Text = "label";

            ListItemAuthor.Text = "label";

            ListItemTime.Text = "label";

            ListItemIndex.Text = "label";
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
            return new StoryListItem();
        }

    }
}
