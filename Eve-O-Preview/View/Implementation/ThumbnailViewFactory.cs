﻿using System;
using System.Drawing;

namespace EveOPreview.View
{
	sealed class ThumbnailViewFactory : IThumbnailViewFactory
	{
		private readonly IApplicationController _controller;

		public ThumbnailViewFactory(IApplicationController controller)
		{
			this._controller = controller;
		}

		public IThumbnailView Create(IntPtr id, string title, Size size)
		{
			IThumbnailView view = this._controller.Create<IThumbnailView>();

			view.Id = id;
			view.Title = title;
			view.ThumbnailSize = size;

			return view;
		}
	}
}