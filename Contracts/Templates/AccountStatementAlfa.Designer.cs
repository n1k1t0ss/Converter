﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsvTo1C.Contracts.Templates {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class AccountStatementAlfa {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AccountStatementAlfa() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CsvTo1C.Contracts.Templates.AccountStatementAlfa", typeof(AccountStatementAlfa).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1CClientBankExchange
        ///ВерсияФормата=1.01
        ///Кодировка=Windows
        ///Отправитель=Альфа-Бизнес Онлайн
        ///Получатель=
        ///ДатаСоздания={create_date}
        ///ВремяСоздания=
        ///ДатаНачала={b_date}
        ///ДатаКонца={m_date}
        ///РасчСчет={Rch}
        ///
        ///СекцияРасчСчет
        ///ДатаНачала={b_date}
        ///ДатаКонца={m_date}
        ///РасчСчет={Rch}
        ///НачальныйОстаток={bc_val}
        ///ВсегоПоступило={Sc_val}
        ///ВсегоСписано={Sd_val}
        ///КонечныйОстаток={Tc_val}
        ///КонецРасчСчет
        ///
        ///.
        /// </summary>
        public static string Begin {
            get {
                return ResourceManager.GetString("Begin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///КонецФайла.
        /// </summary>
        public static string End {
            get {
                return ResourceManager.GetString("End", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to СекцияДокумент=
        ///Номер={number}
        ///Дата={o_date}
        ///Сумма={sum_val}
        ///ПлательщикСчет={plat_acc}
        ///ДатаСписано={DATE_SPIS}
        ///Плательщик={plat_name}
        ///ПлательщикИНН={plat_inn}
        ///ПлательщикКПП={plat_kpp}
        ///ПлательщикРасчСчет={plat_acc}
        ///ПлательщикБанк1={plat_bank}
        ///ПлательщикБИК={plat_bic}
        ///ПлательщикКорсчет={plat_ks}
        ///ПолучательСчет={pol_acc}
        ///ДатаПоступило={DATE_POST}
        ///Получатель={pol_name}
        ///ПолучательИНН={Pol_inn}
        ///ПолучательКПП={pol_kpp}
        ///ПолучательРасчСчет={pol_acc}
        ///ПолучательБанк1={pol_bank}
        ///ПолучательБИК={pol_b [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Row {
            get {
                return ResourceManager.GetString("Row", resourceCulture);
            }
        }
    }
}
