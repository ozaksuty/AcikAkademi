using Foundation;
using System;
using UIKit;

namespace Ders7ek
{
    public class TableSource : UITableViewSource
    {
        string[] tableItems;
        string cellIdentifier = "TableCell";

        public TableSource(string[] items)
        {
            this.tableItems = items;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Subtitle,
                    cellIdentifier);
            }

            cell.TextLabel.Text = tableItems[indexPath.Row];
            cell.DetailTextLabel.Text = tableItems[indexPath.Row];
            cell.DetailTextLabel.TextColor = UIColor.Red;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            //base.RowSelected(tableView, indexPath);

            new UIAlertView("Açık Akademi", tableItems[indexPath.Row], null, "Ok", null).Show();
            tableView.DeselectRow(indexPath, true);
        }
    }
}
