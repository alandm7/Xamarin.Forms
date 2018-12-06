using System;

namespace Xamarin.Forms.Platform.Android
{
	internal class EmptySource : IItemsViewSource
	{
		public int Count => 0;

		public object this[int index] => throw new IndexOutOfRangeException("IItemsViewSource is empty");

		public void Dispose()
		{
			Dispose(true);
		}

		bool _disposed;

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{

				}

				_disposed = true;
			}
		}
	}
}