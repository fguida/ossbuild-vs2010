#
# Makefile.am for the Nice Glib ICE library
#
# (C) 2006, 2007 Collabora Ltd.
# (C) 2006, 2007 Nokia Corporation. All rights reserved.
#
# Licensed under MPL 1.1/LGPL 2.1. See file COPYING.

include $(top_srcdir)/common.mk

AM_CFLAGS = \
	-DG_LOG_DOMAIN=\"libnice-socket\" \
	$(ERROR_CFLAGS) \
	$(GLIB_CFLAGS) \
	$(GUPNP_CFLAGS) \
	-I $(top_srcdir)/random \
	-I $(top_srcdir)/agent \
	-I $(top_srcdir)/

noinst_LTLIBRARIES = libsocket.la

libsocket_la_SOURCES = \
	socket.h \
	socket.c \
	udp-bsd.h \
	udp-bsd.c \
	tcp-bsd.h \
	tcp-bsd.c \
	pseudossl.h \
	pseudossl.c \
	socks5.h \
	socks5.c \
	http.h \
	http.c \
	turn.h \
	turn.c \
	tcp-turn.h \
	tcp-turn.c


pkginclude_HEADERS = socket.h udp-bsd.h tcp-bsd.h pseudossl.h http.h socks5.h turn.h tcp-turn.h

