
all:
	$(MAKE) -C Engine
	$(MAKE) -C Mario
	$(MAKE) -C MapEditor

purge:
	$(MAKE) -C Engine clean
	$(MAKE) -C Mario clean
	$(MAKE) -C MapEditor clean
