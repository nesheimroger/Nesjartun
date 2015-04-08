# CoffeeScript
(($, window) ->

    $(window).ready  ->
    
        if Modernizr.mq('(max-width: 767px)')
            return;

        rows = $('.row');
        rows.each (index, rowElement) =>
    
            row = $(rowElement);
            sections = row.find('.content-section');
            if sections.length > 1
                height = 0;
                sections.each (index, sectionElement) =>
                    sectionHeight = $(sectionElement).outerHeight()
                    
                    
                    if sectionHeight > height
                        height = sectionHeight;
                    return;
                sections.height(height)
                return;

    

) jQuery, window