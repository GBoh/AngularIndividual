'use strict';

(function () {
    angular
        .module('MFTWeb')
        .controller('TermController', function ($http, $location, termService) {
            console.log('hi');
            var self = this;
            //var test = termService.getTerms();
            //console.log(test);
            self.listTerms = termService.getTerms();
           
        });
})();