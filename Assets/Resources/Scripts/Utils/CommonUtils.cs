using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CommonUtils {

    public static List<string> GetTags(string target) {
        List<string> tags = new List<string>();
        StringBuilder tagBuilder = new StringBuilder();
        for (int i = 0; i < target.Length; i++) {
            char thisChar = target.ElementAt(i);
            if (tagBuilder.Length != 0) {
                tagBuilder.Append(thisChar);
                if (target.ElementAt(i) == '>') {
                    tags.Add(tagBuilder.ToString());
                    tagBuilder = new StringBuilder();
                }
            }
            else if (thisChar == '<') {
                tagBuilder.Append(thisChar);
            }
        }
        return tags;
    }

}
