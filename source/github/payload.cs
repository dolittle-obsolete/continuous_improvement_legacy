/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace github
{
    #pragma warning disable 1591
    public class payload
    {
        public string zen;
        public int hook_id;
        public hook hook;
        public repository repository;
        public user sender;
    }
}