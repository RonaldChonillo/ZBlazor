using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace ZBlazor.QuickAutocomplete
{
	/// <summary>
	/// The container for an individual item in a QuickAutocomplete.
	/// </summary>
	public partial class SearchItem<TDataObject>
	{
        public string TextForRender { get; set; } = "";

        #region METHODS

        /// <summary>
        /// Gets markup for a SearchItem for display in the items list. Use this in a template to highlight the matching characters of an item.
        /// </summary>
        public MarkupString GetDisplayTextV2(bool highlightMatches = true, bool showOtherMatches = true)
		{
			if (!highlightMatches || Matches == null || string.IsNullOrWhiteSpace(TextForRender))
			{
				return (MarkupString)$"<span class=\"zb-quick-autocomplete-filter-match\">{TextForRender}</span>";
			}

			if (highlightMatches && Matches != null && OtherMatchFieldValue == null && OtherMatchFieldValue == null)
			{
				return (MarkupString)$"<span class=\"zb-quick-autocomplete-filter-match\">{GetMatchesMarkup(Matches, TextForRender)}</span>";
			}

			if (highlightMatches && showOtherMatches && Matches != null && OtherMatchFieldName != null && OtherMatchFieldValue != null)
			{
				var result = new System.Text.StringBuilder();
				result.Append(TextForRender);
				result.Append($"<span class=\"zb-quick-autocomplete-filter-match\"><br/><small>Matches {OtherMatchFieldName}: {GetMatchesMarkup(Matches, OtherMatchFieldValue)}</small></span>");
				return (MarkupString)result.ToString();
			}

			//_ = TextForRender;

			return (MarkupString)$"<span class=\"zb-quick-autocomplete-filter-match\">{TextForRender}</span>";
		}


		#endregion METHODS
	}
}
