(function() {
  (function($, window) {
    var equalizeHeights;
    equalizeHeights = function() {
      var rows;
      rows = $('.row');
      return rows.each((function(_this) {
        return function(index, rowElement) {
          var height, row, sections;
          row = $(rowElement);
          sections = row.find('.content-section');
          if (sections.length > 1) {
            sections.height('auto');
            if (Modernizr.mq('(max-width: 767px)')) {
              return;
            }
            height = 0;
            sections.each(function(index, sectionElement) {
              var sectionHeight;
              sectionHeight = $(sectionElement).outerHeight();
              if (sectionHeight > height) {
                height = sectionHeight;
              }
            });
            sections.height(height);
          }
        };
      })(this));
    };
    $(window).ready(function() {
      equalizeHeights();
    });
    $(window).resize(function() {
      equalizeHeights();
    });
  })(jQuery, window);

}).call(this);

//# sourceMappingURL=nesjartun.js.map
