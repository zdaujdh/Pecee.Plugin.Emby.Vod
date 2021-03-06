﻿using System;
using System.Runtime.Serialization;
using MediaBrowser.Controller.Entities.TV;

namespace Pecee.Emby.Plugin.Vod.Models
{
	public class VodSeries : Series, IVodMedia
	{
		public Guid IdentifierId { get; set; }

		[IgnoreDataMember]
		public VodPlaylist Playlist { get; set; }

	}
}
