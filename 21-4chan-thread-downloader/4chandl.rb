#!/usr/bin/env ruby
require 'uri'
require 'net/http'
require 'open-uri'

require 'rubygems'
require 'hpricot'

unless ARGV[0] and ARGV[1]
    puts "Usage: #{$0} <link to 4chan thread> <path to images folder>"
    exit 1
end

thread_link, folder_path = ARGV
print "Grabbing page and parsing HTML..."
doc = open(thread_link) do |f| Hpricot(f) end
puts "Done, finding images!"

doc.search(".file").each do |file|
    href = file.search(".fileText").first.search("a").first
    image_url = "http:" + href["href"]
    image_info = file.search(".mFileInfo").first.inner_html
    image_original_name = href.inner_html

    print "Found image: #{image_url} (#{image_info}) (Original: #{image_original_name}). Downloading..."
    file_name = File.basename(image_url)

    uri = URI(image_url)
    Net::HTTP.start(uri.host, 80) do |http|
        http.request_get(uri.path) do |resp|
            File.open(File.join(folder_path, file_name), "wb") do |f|
                resp.read_body do |chunk|
                    f.write(chunk)
                end
            end
        end
    end
    puts "Done!"
end

puts "Done!"