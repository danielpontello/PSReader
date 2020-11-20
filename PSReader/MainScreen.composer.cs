// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSReader
{
    partial class MainScreen
    {
        Panel TitlePanel;
        Label TitleText;
        Label Label_1;
        Label ContentLabel;
        Panel StatusPanel;
        Label Status;
        ListPanel StoryList;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            TitlePanel = new Panel();
            TitlePanel.Name = "TitlePanel";
            TitleText = new Label();
            TitleText.Name = "TitleText";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            ContentLabel = new Label();
            ContentLabel.Name = "ContentLabel";
            StatusPanel = new Panel();
            StatusPanel.Name = "StatusPanel";
            Status = new Label();
            Status.Name = "Status";
            StoryList = new ListPanel();
            StoryList.Name = "StoryList";

            // MainScreen
            this.RootWidget.AddChildLast(TitlePanel);
            this.RootWidget.AddChildLast(ContentLabel);
            this.RootWidget.AddChildLast(StatusPanel);
            this.RootWidget.AddChildLast(StoryList);

            // TitlePanel
            TitlePanel.BackgroundColor = new UIColor(255f / 255f, 102f / 255f, 0f / 255f, 255f / 255f);
            TitlePanel.Clip = true;
            TitlePanel.AddChildLast(TitleText);
            TitlePanel.AddChildLast(Label_1);

            // TitleText
            TitleText.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            TitleText.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            TitleText.LineBreak = LineBreak.Character;

            // Label_1
            Label_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.HorizontalAlignment = HorizontalAlignment.Right;

            // ContentLabel
            ContentLabel.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            ContentLabel.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            ContentLabel.LineBreak = LineBreak.Character;
            ContentLabel.VerticalAlignment = VerticalAlignment.Top;

            // StatusPanel
            StatusPanel.BackgroundColor = new UIColor(255f / 255f, 102f / 255f, 0f / 255f, 255f / 255f);
            StatusPanel.Clip = true;
            StatusPanel.AddChildLast(Status);

            // Status
            Status.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Status.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Status.LineBreak = LineBreak.Character;

            // StoryList
            StoryList.ScrollBarVisibility = ScrollBarVisibility.ScrollableVisible;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    TitlePanel.SetPosition(0, 0);
                    TitlePanel.SetSize(100, 100);
                    TitlePanel.Anchors = Anchors.None;
                    TitlePanel.Visible = true;

                    TitleText.SetPosition(12, 0);
                    TitleText.SetSize(214, 36);
                    TitleText.Anchors = Anchors.None;
                    TitleText.Visible = true;

                    Label_1.SetPosition(12, 0);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    ContentLabel.SetPosition(0, 0);
                    ContentLabel.SetSize(214, 36);
                    ContentLabel.Anchors = Anchors.None;
                    ContentLabel.Visible = true;

                    StatusPanel.SetPosition(0, 0);
                    StatusPanel.SetSize(100, 100);
                    StatusPanel.Anchors = Anchors.None;
                    StatusPanel.Visible = true;

                    Status.SetPosition(12, 0);
                    Status.SetSize(214, 36);
                    Status.Anchors = Anchors.None;
                    Status.Visible = true;

                    StoryList.SetPosition(0, 40);
                    StoryList.SetSize(854, 400);
                    StoryList.Anchors = Anchors.None;
                    StoryList.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    TitlePanel.SetPosition(0, 0);
                    TitlePanel.SetSize(960, 40);
                    TitlePanel.Anchors = Anchors.None;
                    TitlePanel.Visible = true;

                    TitleText.SetPosition(8, 0);
                    TitleText.SetSize(214, 40);
                    TitleText.Anchors = Anchors.None;
                    TitleText.Visible = true;

                    Label_1.SetPosition(735, 0);
                    Label_1.SetSize(214, 40);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    ContentLabel.SetPosition(479, 40);
                    ContentLabel.SetSize(481, 464);
                    ContentLabel.Anchors = Anchors.None;
                    ContentLabel.Visible = true;

                    StatusPanel.SetPosition(0, 504);
                    StatusPanel.SetSize(960, 40);
                    StatusPanel.Anchors = Anchors.None;
                    StatusPanel.Visible = true;

                    Status.SetPosition(8, 0);
                    Status.SetSize(214, 40);
                    Status.Anchors = Anchors.None;
                    Status.Visible = true;

                    StoryList.SetPosition(0, 40);
                    StoryList.SetSize(479, 464);
                    StoryList.Anchors = Anchors.None;
                    StoryList.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            TitleText.Text = "Hacker News";

            Label_1.Text = "00:43";

            ContentLabel.Text = "Hello World!";

            Status.Text = "Done";
        }

        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

    }
}
