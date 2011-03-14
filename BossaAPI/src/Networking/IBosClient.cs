﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pjank.BossaAPI.DTO;

namespace pjank.BossaAPI
{
	public interface IBosClient : IDisposable
	{
		/// <summary>
		/// Zdarzenie informujące o aktualizacji danych rachunku.
		/// </summary>
		event Action<AccountData> AccountUpdateEvent;
		/// <summary>
		/// Zdarzenie informujące o aktualizacji informacji o zleceniu na rachunku.
		/// </summary>
		event Action<OrderData> OrderUpdateEvent;

		/// <summary>
		/// Utworzenie nowego zlecenia.
		/// </summary>
		/// <param name="data">Obiekt z danymi nowego zlecenia.
		/// Wypełnić należy: Nr rachunku, ClientId i komplet informacji o zleceniu (MainData).</param>
		void OrderCreate(OrderData data);
		/// <summary>
		/// Modyfikacja wcześniejszego zlecenia.
		/// </summary>
		/// <param name="data">Obiekt ze zmodyfikowanymi danymi zlecenia.
		/// Wypełnić należy: Nr rachunku, obecne Id zlecenia i nowy komplet informacji o nim (MainData).</param>
		void OrderReplace(OrderData data);
		/// <summary>
		/// Anulowanie podanego zlecenia.
		/// </summary>
		/// <param name="data">Obiekt z danymi zlecenia do anulowania.
		/// Wypełnić należy: Nr rachunku, obecne Id zlecenia i jego podstawowe dane (instrument, strona, ilość).</param>
		void OrderCancel(OrderData data);
	}
}
