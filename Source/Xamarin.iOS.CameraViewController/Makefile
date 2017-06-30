all: native-references-built

native-references-built:
	$(MAKE) -C NativeReferences all
	touch native-references-built

clean:
	$(MAKE) -C NativeReferences clean
	rm -f native-references-built

.PHONY: all
