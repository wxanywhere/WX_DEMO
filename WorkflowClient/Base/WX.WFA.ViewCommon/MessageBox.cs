using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WX.WFA.ViewCommon
{
    public static class MessageX
    {
        /// <summary>
        /// 提示成功
        /// </summary>
        /// <param name="message">文本消息</param>
        /// <example> 下面的示例演示如何显示提示成功的消息
        /// <code>
        ///private void DeleteJGXX()
        ///{
        ///    <c>Commonality</c>.ShowSuccess("删除成功");
        ///}
        /// </code>
        /// </example>
        /// <returns>返回消息确认结果</returns>
        public static MessageBoxResult ShowSuccess(string message)
        {
            return MessageBox.Show(message,"成功提示！",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        /// <summary>
        /// 提示消息
        /// </summary>
        /// <param name="message">文本消息</param>
        /// <example> 下面的示例演示如何显示提示普通的消息
        /// <code>
        ///private void Delete()
        ///{
        ///    <c>Commonality</c>.ShowInfo("删除成功");
        ///}
        /// </code>
        /// </example>
        /// <returns>返回消息确认结果</returns>
        public static MessageBoxResult ShowInfo(string message)
        {
            return MessageBox.Show(message, "提示信息！", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// 错误消息
        /// </summary>
        /// <example> 下面的示例演示如何显示提示错误的消息
        /// <code>
        ///private void Delete()
        ///{
        ///    <c>Commonality</c>.ShowError("当前未选中任何行进行删除，请选择!");
        ///}
        /// </code>
        /// </example>
        /// <param name="message">文本消息</param>
        /// <returns>返回消息确认结果</returns>
        public static MessageBoxResult ShowError(string message)
        {
            return MessageBox.Show(message, "错误信息！", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// 确认消息
        /// </summary>
        /// <param name="message">文本消息</param>
        /// <example> 下面的示例演示如何显示提示确认的消息
        /// <code>
        ///private void Delete()
        ///{
        ///     if (Commonality.ShowConfirm("是否要取消？如果取消信息将不保存.") <c>!= MessageBoxResult</c>.Show.Cancel)
        ///     {
        ///        
        ///     }
        ///}
        /// </code>
        /// </example>
        /// <returns>返回消息确认结果</returns>
        public static MessageBoxResult ShowConfirm(string message)
        {
            return MessageBox.Show(message, "操作确认！", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }
}
