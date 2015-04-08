(function() {
  (function($, window) {
    return $(window).ready(function() {
      var rows;
      if (Modernizr.mq('(max-width: 767px)')) {
        return;
      }
      rows = $('.row');
      return rows.each((function(_this) {
        return function(index, rowElement) {
          var height, row, sections;
          row = $(rowElement);
          sections = row.find('.content-section');
          if (sections.length > 1) {
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
    });
  })(jQuery, window);

}).call(this);

//# sourceMappingURL=nesjartun.js.map
