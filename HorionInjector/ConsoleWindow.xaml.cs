using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;

namespace HorionInjector
{
	// Token: 0x02000003 RID: 3
	public partial class ConsoleWindow : Window
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000020A4 File Offset: 0x000002A4
		public ConsoleWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020B2 File Offset: 0x000002B2
		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}
	}
}
