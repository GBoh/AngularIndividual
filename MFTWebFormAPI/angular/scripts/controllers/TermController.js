
(function () {
    angular
        .module('MFTWeb')
        .controller('TermController', function ($location, termService, currentUser) {
            var self = this;
            this.username = currentUser.profile.username;
            this.listTerms = termService.getTerms();

            this.addTerm = function () {
                var term = {name: self.newTerm, user: self.username}
                termService.postTerm(term);
                self.listTerms = termService.getTerms();
            };

            this.newMFTEntry = function () {
                console.log('new entry');
                $location.path('/newMft');
            };
        });
})();