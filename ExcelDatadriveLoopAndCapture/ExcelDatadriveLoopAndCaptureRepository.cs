﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ExcelDatadriveLoopAndCapture
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the ExcelDatadriveLoopAndCaptureRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    [RepositoryFolder("d8f117c2-421b-4149-ad7b-f1554ef9f939")]
    public partial class ExcelDatadriveLoopAndCaptureRepository : RepoGenBaseFolder
    {
        static ExcelDatadriveLoopAndCaptureRepository instance = new ExcelDatadriveLoopAndCaptureRepository();
        ExcelDatadriveLoopAndCaptureRepositoryFolders.EdgewordsTrainingAutomatedSoftwareAppFolder _edgewordstrainingautomatedsoftware;

        /// <summary>
        /// Gets the singleton class instance representing the ExcelDatadriveLoopAndCaptureRepository element repository.
        /// </summary>
        [RepositoryFolder("d8f117c2-421b-4149-ad7b-f1554ef9f939")]
        public static ExcelDatadriveLoopAndCaptureRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public ExcelDatadriveLoopAndCaptureRepository() 
            : base("ExcelDatadriveLoopAndCaptureRepository", "/", null, 0, false, "d8f117c2-421b-4149-ad7b-f1554ef9f939", ".\\RepositoryImages\\ExcelDatadriveLoopAndCaptureRepositoryd8f117c2.rximgres")
        {
            _edgewordstrainingautomatedsoftware = new ExcelDatadriveLoopAndCaptureRepositoryFolders.EdgewordsTrainingAutomatedSoftwareAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("d8f117c2-421b-4149-ad7b-f1554ef9f939")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The EdgewordsTrainingAutomatedSoftware folder.
        /// </summary>
        [RepositoryFolder("82b4623e-ffe9-48b8-b6ba-62b3d6404c80")]
        public virtual ExcelDatadriveLoopAndCaptureRepositoryFolders.EdgewordsTrainingAutomatedSoftwareAppFolder EdgewordsTrainingAutomatedSoftware
        {
            get { return _edgewordstrainingautomatedsoftware; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    public partial class ExcelDatadriveLoopAndCaptureRepositoryFolders
    {
        /// <summary>
        /// The EdgewordsTrainingAutomatedSoftwareAppFolder folder.
        /// </summary>
        [RepositoryFolder("82b4623e-ffe9-48b8-b6ba-62b3d6404c80")]
        public partial class EdgewordsTrainingAutomatedSoftwareAppFolder : RepoGenBaseFolder
        {
            ExcelDatadriveLoopAndCaptureRepositoryFolders.MenuMainFolder _menumain;
            ExcelDatadriveLoopAndCaptureRepositoryFolders.ArticlesFolder _articles;
            RepoItemInfo _articleheadersInfo;
            RepoItemInfo _articlebodyInfo;
            RepoItemInfo _nextInfo;
            RepoItemInfo _postscontainerInfo;

            /// <summary>
            /// Creates a new EdgewordsTrainingAutomatedSoftware  folder.
            /// </summary>
            public EdgewordsTrainingAutomatedSoftwareAppFolder(RepoGenBaseFolder parentFolder) :
                    base("EdgewordsTrainingAutomatedSoftware", "/dom[@domain='www.edgewordstraining.co.uk' and @state='complete']", parentFolder, 30000, null, false, "82b4623e-ffe9-48b8-b6ba-62b3d6404c80", "")
            {
                _menumain = new ExcelDatadriveLoopAndCaptureRepositoryFolders.MenuMainFolder(this);
                _articles = new ExcelDatadriveLoopAndCaptureRepositoryFolders.ArticlesFolder(this);
                _articleheadersInfo = new RepoItemInfo(this, "ArticleHeaders", ".//div[#'posts-container']//article//h2", 30000, null, "17f9820c-2e06-4e2a-9ad3-63f654d838cf");
                _articlebodyInfo = new RepoItemInfo(this, "ArticleBody", ".//div[#'posts-container']//article//div[@class='fusion-post-content-container']", 30000, null, "76e2987d-f200-4e07-a095-f847ec5cd41d");
                _nextInfo = new RepoItemInfo(this, "Next", ".//div[#'posts-container']//a[@class='pagination-next']/span[@innertext='Next']", 30000, null, "75d4d7e6-7a97-41cd-b14e-cc3925e6f431");
                _postscontainerInfo = new RepoItemInfo(this, "PostsContainer", ".//div[#'posts-container']", 30000, null, "c32dc442-1451-4832-b5a1-4ebf32e60f45");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("82b4623e-ffe9-48b8-b6ba-62b3d6404c80")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("82b4623e-ffe9-48b8-b6ba-62b3d6404c80")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ArticleHeaders item.
            /// </summary>
            [RepositoryItem("17f9820c-2e06-4e2a-9ad3-63f654d838cf")]
            public virtual Ranorex.H2Tag ArticleHeaders
            {
                get
                {
                    return _articleheadersInfo.CreateAdapter<Ranorex.H2Tag>(true);
                }
            }

            /// <summary>
            /// The ArticleHeaders item info.
            /// </summary>
            [RepositoryItemInfo("17f9820c-2e06-4e2a-9ad3-63f654d838cf")]
            public virtual RepoItemInfo ArticleHeadersInfo
            {
                get
                {
                    return _articleheadersInfo;
                }
            }

            /// <summary>
            /// The ArticleBody item.
            /// </summary>
            [RepositoryItem("76e2987d-f200-4e07-a095-f847ec5cd41d")]
            public virtual Ranorex.DivTag ArticleBody
            {
                get
                {
                    return _articlebodyInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The ArticleBody item info.
            /// </summary>
            [RepositoryItemInfo("76e2987d-f200-4e07-a095-f847ec5cd41d")]
            public virtual RepoItemInfo ArticleBodyInfo
            {
                get
                {
                    return _articlebodyInfo;
                }
            }

            /// <summary>
            /// The Next item.
            /// </summary>
            [RepositoryItem("75d4d7e6-7a97-41cd-b14e-cc3925e6f431")]
            public virtual Ranorex.SpanTag Next
            {
                get
                {
                    return _nextInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Next item info.
            /// </summary>
            [RepositoryItemInfo("75d4d7e6-7a97-41cd-b14e-cc3925e6f431")]
            public virtual RepoItemInfo NextInfo
            {
                get
                {
                    return _nextInfo;
                }
            }

            /// <summary>
            /// The PostsContainer item.
            /// </summary>
            [RepositoryItem("c32dc442-1451-4832-b5a1-4ebf32e60f45")]
            public virtual Ranorex.DivTag PostsContainer
            {
                get
                {
                    return _postscontainerInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The PostsContainer item info.
            /// </summary>
            [RepositoryItemInfo("c32dc442-1451-4832-b5a1-4ebf32e60f45")]
            public virtual RepoItemInfo PostsContainerInfo
            {
                get
                {
                    return _postscontainerInfo;
                }
            }

            /// <summary>
            /// The MenuMain folder.
            /// </summary>
            [RepositoryFolder("18033a7b-5313-4755-b1f0-f3e6ea91b07f")]
            public virtual ExcelDatadriveLoopAndCaptureRepositoryFolders.MenuMainFolder MenuMain
            {
                get { return _menumain; }
            }

            /// <summary>
            /// The Articles folder.
            /// </summary>
            [RepositoryFolder("b31228fc-287f-4023-87f9-e9021aaab1dc")]
            public virtual ExcelDatadriveLoopAndCaptureRepositoryFolders.ArticlesFolder Articles
            {
                get { return _articles; }
            }
        }

        /// <summary>
        /// The MenuMainFolder folder.
        /// </summary>
        [RepositoryFolder("18033a7b-5313-4755-b1f0-f3e6ea91b07f")]
        public partial class MenuMainFolder : RepoGenBaseFolder
        {
            RepoItemInfo _searchInfo;
            RepoItemInfo _inputtagsInfo;
            RepoItemInfo _submitInfo;

            /// <summary>
            /// Creates a new MenuMain  folder.
            /// </summary>
            public MenuMainFolder(RepoGenBaseFolder parentFolder) :
                    base("MenuMain", ".//ul[#'menu-main']", parentFolder, 30000, null, false, "18033a7b-5313-4755-b1f0-f3e6ea91b07f", "")
            {
                _searchInfo = new RepoItemInfo(this, "Search", "?/?/a[@title='Search']", 30000, null, "655ce6c9-b0d1-4471-86d5-d96e3329c28e");
                _inputtagsInfo = new RepoItemInfo(this, "InputTagS", "li[9]/?/?/form[@action='https://www.edgewordstraining.co.uk/']//input[@name='s']", 30000, null, "8eeb1ee5-f880-484c-b42b-65b1499c4b5a");
                _submitInfo = new RepoItemInfo(this, "Submit", "li[9]/?/?/form[@action='https://www.edgewordstraining.co.uk/']//input[@type='submit']", 30000, null, "0891cd0d-a057-4019-af7b-81e5aa34df3a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("18033a7b-5313-4755-b1f0-f3e6ea91b07f")]
            public virtual Ranorex.UlTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.UlTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("18033a7b-5313-4755-b1f0-f3e6ea91b07f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Search item.
            /// </summary>
            [RepositoryItem("655ce6c9-b0d1-4471-86d5-d96e3329c28e")]
            public virtual Ranorex.ATag Search
            {
                get
                {
                    return _searchInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Search item info.
            /// </summary>
            [RepositoryItemInfo("655ce6c9-b0d1-4471-86d5-d96e3329c28e")]
            public virtual RepoItemInfo SearchInfo
            {
                get
                {
                    return _searchInfo;
                }
            }

            /// <summary>
            /// The InputTagS item.
            /// </summary>
            [RepositoryItem("8eeb1ee5-f880-484c-b42b-65b1499c4b5a")]
            public virtual Ranorex.InputTag InputTagS
            {
                get
                {
                    return _inputtagsInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputTagS item info.
            /// </summary>
            [RepositoryItemInfo("8eeb1ee5-f880-484c-b42b-65b1499c4b5a")]
            public virtual RepoItemInfo InputTagSInfo
            {
                get
                {
                    return _inputtagsInfo;
                }
            }

            /// <summary>
            /// The Submit item.
            /// </summary>
            [RepositoryItem("0891cd0d-a057-4019-af7b-81e5aa34df3a")]
            public virtual Ranorex.InputTag Submit
            {
                get
                {
                    return _submitInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Submit item info.
            /// </summary>
            [RepositoryItemInfo("0891cd0d-a057-4019-af7b-81e5aa34df3a")]
            public virtual RepoItemInfo SubmitInfo
            {
                get
                {
                    return _submitInfo;
                }
            }
        }

        /// <summary>
        /// The ArticlesFolder folder.
        /// </summary>
        [RepositoryFolder("b31228fc-287f-4023-87f9-e9021aaab1dc")]
        public partial class ArticlesFolder : RepoGenBaseFolder
        {
            RepoItemInfo _entrytitlefusionposttitleInfo;

            /// <summary>
            /// Creates a new Articles  folder.
            /// </summary>
            public ArticlesFolder(RepoGenBaseFolder parentFolder) :
                    base("Articles", ".//div[#'posts-container']//article", parentFolder, 30000, null, false, "b31228fc-287f-4023-87f9-e9021aaab1dc", "")
            {
                _entrytitlefusionposttitleInfo = new RepoItemInfo(this, "EntryTitleFusionPostTitle", ".//h2", 30000, null, "7885bf79-510d-456f-b321-98d841a04dee");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b31228fc-287f-4023-87f9-e9021aaab1dc")]
            public virtual Ranorex.ArticleTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ArticleTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b31228fc-287f-4023-87f9-e9021aaab1dc")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EntryTitleFusionPostTitle item.
            /// </summary>
            [RepositoryItem("7885bf79-510d-456f-b321-98d841a04dee")]
            public virtual Ranorex.H2Tag EntryTitleFusionPostTitle
            {
                get
                {
                    return _entrytitlefusionposttitleInfo.CreateAdapter<Ranorex.H2Tag>(true);
                }
            }

            /// <summary>
            /// The EntryTitleFusionPostTitle item info.
            /// </summary>
            [RepositoryItemInfo("7885bf79-510d-456f-b321-98d841a04dee")]
            public virtual RepoItemInfo EntryTitleFusionPostTitleInfo
            {
                get
                {
                    return _entrytitlefusionposttitleInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}